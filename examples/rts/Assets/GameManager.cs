using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public event Action<UnitScript> UnitSelectedHappened;

    public static GameManager SharedInstance;
    public List<UnitScript> units = new List<UnitScript>();
    public GameObject unitPrefab;

    UnitScript selectedUnit;

    void Awake()
    {
        if (SharedInstance != null)
        {
            Debug.Log("Why is there more than one GameManager!?!?!?!");
        }
        SharedInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 999999))
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("ground"))
                {
                    // If we get in here, we hit something! And the 'hit' object
                    // contains info about what we hit.
                    if (selectedUnit != null)
                    {
                        selectedUnit.SetTarget(hit.point);
                    }
                }
            }
        }
    }

    public void SelectUnit(UnitScript unit)
    {
        // Deselect any units that think they are selected
        foreach (UnitScript u in units) {
            u.selected = false;
            u.SetUnitColor();
        }
        selectedUnit = unit;
        selectedUnit.selected = true;
        selectedUnit.SetUnitColor();

        UnitSelectedHappened?.Invoke(unit);
    }
}

// IGNORE THIS FOR NOW. We are gonna need this line of code to allow clicks to
// move through UI elements.
//&& !EventSystem.current.IsPointerOverGameObject()