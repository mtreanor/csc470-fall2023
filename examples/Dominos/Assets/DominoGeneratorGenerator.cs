using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoGeneratorGenerator : MonoBehaviour
{
    public GameObject dominoGeneratorPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 80; i++)
        {
            Vector3 pos = transform.position + transform.right * i * (1 + 2/80f);
            GameObject domGen = Instantiate(dominoGeneratorPrefab, pos, transform.rotation);
            domGen.GetComponent<DominoGenerator>().hueOffset = Mathf.Abs(Mathf.Sin(i / 80f * 4));
            domGen.GetComponent<DominoGenerator>().index = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
