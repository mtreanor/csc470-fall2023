using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoGenerator : MonoBehaviour
{
    // Remember to assign this value in the Unity editor!
    public GameObject dominoPrefab;

    // This is how many dominos we'll generate
    int numDominos = 100;

    // This is the distance we will put between each domino we generate.
    float spacing = 0.8f;

    public int index = 50;

    GameObject firstDomino;

    public float hueOffset = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < index + 1; i++)
        {
            // Compute a position in front of the generator object at a distance
            // based on the iterator variable and the spacing variable.
            Vector3 pos = transform.position + transform.forward * i * spacing;

            // Instantiate the domino prefab into a game object at the location
            GameObject domino = Instantiate(dominoPrefab, pos, transform.rotation);

            // Let the instantiated domino know which one it is in the generated
            // row. We can use this to create interesting effects, like
            // determining what color it should be (see the DominoScript).
            domino.GetComponent<DominoScript>().id = i;
            domino.GetComponent<DominoScript>().parentGenerator = this;

            // If this is the first domino created, store a reference to it in a
            // variable. We can then apply a force to it to start the dominos
            // falling (see Update below).
            if (i == 0)
            {
                firstDomino = domino;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // When the spacce bar is pressed, apply a force to the first domino
        // beginning the chain of dominos falling.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = firstDomino.GetComponent<Rigidbody>();
            rb.AddForce(firstDomino.transform.forward * 100);
        }
    }
}
