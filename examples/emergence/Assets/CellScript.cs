using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
    public bool alive = false;
    GameOfLife gol;

    public int x = -1;
    public int y = -1;

    public Color aliveColor;
    public Color deadColor;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        GameObject golObj = GameObject.Find("GameOfLifeObj");
        gol = golObj.GetComponent<GameOfLife>();

        rend = gameObject.GetComponentInChildren<Renderer>();
        UpdateColor();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateColor()
    {
        if (alive)
        {
            rend.material.color = aliveColor;
        } else
        {
            rend.material.color = deadColor;
        }
    }

    private void OnMouseDown()
    {
        alive = !alive;
        UpdateColor();

        Debug.Log(CountLiveNeighbors());
    }

    int CountLiveNeighbors()
    {
        int alive = 0;

        for (int xIndex = x - 1; xIndex <= x + 1; xIndex++)
        {
            for (int yIndex = y - 1; yIndex <= y + 1; yIndex++)
            {
                if (gol.cells[xIndex, yIndex].alive)
                {
                    alive++;
                }
            }
        }

        return alive;
    }
}
