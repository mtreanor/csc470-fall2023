using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaneController : MonoBehaviour
{
    public TMP_Text scoreText;

    int score = 0;

    float forwardSpeed = 15f;

    float xRotationSpeed = 40f;
    float yRotationSpeed = 10f;
    float zRotationSpeed = 40f;

    float bonusSpeed = 0;

    public GameObject cameraObject;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        float xRotation = vAxis * xRotationSpeed * Time.deltaTime;
        float yRotation = hAxis * yRotationSpeed * Time.deltaTime;
        float zRotation = hAxis * zRotationSpeed * Time.deltaTime;

        transform.Rotate(xRotation, yRotation, -zRotation, Space.Self);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            bonusSpeed = 20;
        }
        bonusSpeed -= 5 * Time.deltaTime;
        bonusSpeed = Mathf.Max(0, bonusSpeed);

        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * (forwardSpeed + bonusSpeed);

        cameraObject.transform.position = transform.position + -transform.forward * 10 + Vector3.up * 5;
        cameraObject.transform.LookAt(transform);
    }

    void UpdateScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ring"))
        {
            UpdateScore(1);
        }
    }


}
