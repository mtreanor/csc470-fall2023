using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;


public class GameManager : MonoBehaviour
{
    bool printTimeIsGoingBy = true;

    public GameObject firstPanel;
    public GameObject secondPanel;
    public GameObject thirdPanel;

    public Image fadeImage;

    public RawImage catImage;

    public TMP_Text clickText;

    string catURL = "https://www.fearfreehappyhomes.com/wp-content/uploads/2021/10/Marci-cat-Maggie-1200x797.jpg";

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(FirstDemoOfCoroutine());
        //StartCoroutine(PanelSequence());

        clickText.text = PlayerPrefs.GetInt("clickCount").ToString();

        StartCoroutine(fadeIn());

    }

    // Update is called once per frame
    void Update()
    {
        if (printTimeIsGoingBy)
        {
            Debug.Log("Time is going by");
        }
    }

    IEnumerator fadeIn()
    {
        fadeImage.gameObject.SetActive(true);
        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1);
        while (fadeImage.color.a > 0)
        {
            float newAlpha = fadeImage.color.a - 0.5f * Time.deltaTime;
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, newAlpha);
            yield return null;
        }
        fadeImage.gameObject.SetActive(false);

        StartCoroutine(DisplayCat());
    }

    IEnumerator DisplayCat()
    {
        UnityWebRequest www = UnityWebRequest.Get(catURL);
        www.downloadHandler = new DownloadHandlerTexture();

        yield return www.SendWebRequest();

        Texture2D texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
        catImage.texture = texture;
    }

    IEnumerator FirstDemoOfCoroutine()
    {
        Debug.Log("Started demo function");

        yield return new WaitForSeconds(2);

        printTimeIsGoingBy = false;

        Debug.Log("2 seconds has gone by");
    }

    IEnumerator PanelSequence()
    {
        firstPanel.SetActive(true);

        bool spaceHasBeenPressed = false;
        while (!spaceHasBeenPressed)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spaceHasBeenPressed = true;
            }
            yield return null;
        }

        firstPanel.SetActive(false);
        secondPanel.SetActive(true);

        yield return new WaitForSeconds(0.4f);

        secondPanel.SetActive(false);
        thirdPanel.SetActive(true);

        yield return new WaitForSeconds(1f);

        thirdPanel.SetActive(false);

    }
}
