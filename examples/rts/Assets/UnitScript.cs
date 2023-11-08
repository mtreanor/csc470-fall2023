using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    public string name;

    public Renderer bodyRenderer;
    public CharacterController cc;

    public Color selectedColor;
    public Color hoverColor;
    Color defaultColor;

    float moveSpeed = 5;

    bool hover = false;
    public bool selected = false;

    Vector3 target;
    bool hasTarget = false;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = bodyRenderer.material.color;
        GameManager.SharedInstance.units.Add(this);
    }

    private void OnDestroy()
    {
        GameManager.SharedInstance.units.Remove(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTarget)
        {
            Vector3 vectorToTarget = (target - transform.position).normalized;
            cc.Move(vectorToTarget * moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, target) < 0.5f)
            {
                hasTarget = false;
            }
        }
    }

    public void SetTarget(Vector3 t)
    {
        target = t;
        hasTarget = true;
    }

    private void OnMouseDown()
    {
        GameManager.SharedInstance.SelectUnit(this);
        SetUnitColor();
    }

    private void OnMouseEnter()
    {
        hover = true;
        SetUnitColor();
    }

    private void OnMouseExit()
    {
        hover = false;
        SetUnitColor();
    }

    public void SetUnitColor()
    {
        if (selected)
        {
            bodyRenderer.material.color = selectedColor;
        }
        else if (hover)
        {
            bodyRenderer.material.color = hoverColor;
        }
        else
        {
            bodyRenderer.material.color = defaultColor;
        }
    }
}
