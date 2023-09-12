using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.useGravity = true;
            rb.AddForce(transform.forward * 10);
        }


        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Vector3 amountToMove = transform.forward * 5;
            transform.position = transform.position + amountToMove * Time.deltaTime;
        }

        transform.Rotate(0, 20 * Time.deltaTime, 0);
        transform.localScale = startScale * (1 + Mathf.Sin(Time.time * 0.8f) * 0.5f); 
    }
}
