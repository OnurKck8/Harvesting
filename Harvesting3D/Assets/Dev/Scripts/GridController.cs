using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public int rowLength;
    public int columnLength;

    public float space;

    public GameObject tile;


    void Start()
    {
        for (int x = 0; x < rowLength; x++)
        {
            for (int y = 0; y < columnLength; y++)
            {
                GameObject gems = Instantiate(tile) as GameObject;
                gems.transform.parent = gameObject.transform;
                gems.transform.position = new Vector3(transform.position.x + x * space, 0, transform.position.z + y * space);
            }

        }
    }

    
}
