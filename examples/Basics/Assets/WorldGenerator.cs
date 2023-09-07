using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    // Declaring public variables in a MonoBehaviour script means that you can
    // assign values to these variable in the Unity editor.
    public GameObject treePrefab;
    public GameObject rainPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Generate a 100 trees
        for (int i = 0; i < 100; i++)
        {
            generateTree();
        }
    }

    void generateTree()
    {
        float x = Random.Range(-50, 50);
        float y = 0;
        float z = Random.Range(-50, 50);
        Vector3 pos = new Vector3(x, y, z);
        GameObject treeObj = Instantiate(treePrefab, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // Create a "Rain" object to fall in a random position over the plain.
        float x = Random.Range(-50, 50);
        float y = 20;
        float z = Random.Range(-50, 50);
        Vector3 pos = new Vector3(x, y, z);
        GameObject rain = Instantiate(rainPrefab, pos, Quaternion.identity);
        // Every visible object has a renderer, and so does the instantiated rain
        // prefab. Below, we grab the renderer component on the instantiated rain
        // object, and then assign a random color to it.
        Renderer rainRend = rain.GetComponent<Renderer>();
        rainRend.material.color = new Color(Random.value, Random.value, Random.value);
        // Because we are creating SO MANY of these objects, below we call the Unity
        // function destroy with the parameter to wait 2 seconds before destruction.
        Destroy(rain, 2);
    }
}
