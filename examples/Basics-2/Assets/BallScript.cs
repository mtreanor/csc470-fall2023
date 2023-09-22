using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gmObj = GameObject.Find("GameManagerObject");
        gm = gmObj.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("score"))
        {
            gm.incScore(1);
        }
    }
}
