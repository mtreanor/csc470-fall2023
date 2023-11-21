using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    public string name;

    public Renderer bodyRenderer;
    public CharacterController cc;
    public Animator animator;

    public GameObject sparklePrefab;

    public Color selectedColor;
    public Color hoverColor;
    Color defaultColor;

    float moveSpeed = 5;

    bool hover = false;
    public bool selected = false;

    Vector3 target;
    bool hasTarget = false;


    private void OnEnable()
    {
        GameManager.UnitSelectedHappened += CreateSparkle;
    }

    private void OnDisable()
    {
        GameManager.UnitSelectedHappened -= CreateSparkle;
    }

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = bodyRenderer.material.color;
        GameManager.SharedInstance.units.Add(this);
    }

    void CreateSparkle(UnitScript selectedUnit)
    {
        // Instantiate a sparkle if we arent the selected unit
        if (selectedUnit != this)
        {
            GameObject sparkle = Instantiate(sparklePrefab, transform.position + Vector3.up * 3, Quaternion.identity);
            Destroy(sparkle, 5);
        }
    }

    private void OnDestroy()
    {
        GameManager.SharedInstance.units.Remove(this);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 amountToMove = Vector3.zero;

        if (hasTarget)
        {
            Vector3 vectorToTarget = (target - transform.position).normalized;

            float step = 5 * Time.deltaTime;
            Vector3 rotatedTowardsVector = Vector3.RotateTowards(transform.forward, vectorToTarget, step, 1);
            rotatedTowardsVector.y = 0;
            transform.forward = rotatedTowardsVector;

            amountToMove = transform.forward * moveSpeed * Time.deltaTime;
            cc.Move(amountToMove);

            if (Vector3.Distance(transform.position, target) < 0.5f)
            {
                hasTarget = false;
            }
        }

        //animator.SetFloat("speed", amountToMove.magnitude);
        bool walking = false;
        if (amountToMove.magnitude > 0)
        {
            walking = true;
        }
        animator.SetBool("walking", walking);
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
