using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject unitPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 999999, ~LayerMask.NameToLayer("ground")))
            {
                // If we get in here, we hit something! And the 'hit' object
                // contains info about what we hit.
                Instantiate(unitPrefab, hit.point, Quaternion.identity);
            }
        }
    }
}


//&& !EventSystem.current.IsPointerOverGameObject()