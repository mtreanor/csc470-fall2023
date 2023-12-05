using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.EventSystems;
using UnityEngine.Rendering.PostProcessing;

public class GameManager : MonoBehaviour
{
    public static event Action<UnitScript> UnitSelectedHappened;

    public static GameManager SharedInstance;
    public List<UnitScript> units = new List<UnitScript>();
    public GameObject unitPrefab;

    UnitScript selectedUnit;

    Grain grainEffect;
    public PostProcessProfile ppp;

    void Awake()
    {
        if (SharedInstance != null)
        {
            Debug.Log("Why is there more than one GameManager!?!?!?!");
        }
        SharedInstance = this;
    }

    private void Start()
    {
        ppp.TryGetSettings<Grain>(out grainEffect);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
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

        StartCoroutine(selectionEffect());

        UnitSelectedHappened?.Invoke(unit);
    }

    IEnumerator selectionEffect()
    {
        // 1. set Grain's intensity up to 1
        grainEffect.intensity.Override(1);

        // 2. Wait for a second
        yield return new WaitForSeconds(1);

        // 3. set Grain's intensity to 0
        grainEffect.intensity.Override(0);
    }
}
