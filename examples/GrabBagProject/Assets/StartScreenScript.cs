using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartScreenScript : MonoBehaviour
{
    int clickCount = 0;
    public TMP_Text clickText;

    // Start is called before the first frame update
    void Start()
    {
        clickCount = PlayerPrefs.GetInt("clickCount");
        clickText.text = clickCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
            clickText.text = clickCount.ToString();
        }
    }

    public void StartButtonPressed()
    {
        PlayerPrefs.SetInt("clickCount", clickCount);
        SceneManager.LoadScene("Level1");
    }
}
