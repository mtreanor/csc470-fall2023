using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoScript : MonoBehaviour
{
    public int id;

    public DominoGenerator parentGenerator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This function is called by Unity when the Physics object collides with
    // a collider (because Domino has a Rigidbody).
    private void OnCollisionEnter(Collision collision)
    {
        // The parameter 'collision' is a data structure provided by Unity
        // and it contains information about the collision that occured.
        // It also contains a reference to the gameObject that we collided with.
        if (collision.gameObject.CompareTag("domino"))
        {
            // Here we will change the color to a 'color of the rainbow' based
            // on this domino's id (id was set to be whatever number in order
            // the domino was when it was created.
            Renderer rend = gameObject.GetComponentInChildren<Renderer>();
            // The Color.HSVToRGB function wants three values between 0 and 1.
            // By dividing the number by 50 and applying the modulus operator
            // we get a looping number between 0 and 1 every 50 id numbers.
            float hue = parentGenerator.hueOffset + id / 50f;
            rend.material.color = Color.HSVToRGB(hue % 1f, .9f, 0.8f);
        }
    }
}
