using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text nameText;

    private void OnEnable()
    {
        GameManager.UnitSelectedHappened += UpdateNameText;
    }

    private void OnDisable()
    {
        GameManager.UnitSelectedHappened -= UpdateNameText;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateNameText(UnitScript unit)
    {
        nameText.text = unit.name;
    }
}
