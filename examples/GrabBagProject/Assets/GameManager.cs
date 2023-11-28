using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool printTimeIsGoingBy = true;

    public GameObject firstPanel;
    public GameObject secondPanel;
    public GameObject thirdPanel;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(FirstDemoOfCoroutine());
        StartCoroutine(PanelSequence());

    }

    // Update is called once per frame
    void Update()
    {
        if (printTimeIsGoingBy)
        {
            Debug.Log("Time is going by");
        }
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

        yield return new WaitForSeconds(0.1f);

        thirdPanel.SetActive(false);

    }
}
