using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsController : MonoBehaviour
{
    public static GemsController Instance { get; private set; }

    public GameObject[] gems;

    public bool timeCtrl=false;

    float spawnTime = 3;

    GameObject newGem;

   void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        GameObject gem = Instantiate(gems[Random.Range(0, gems.Length)],transform.position+new Vector3(0,0+0.35f,0),Quaternion.identity);
        gem.transform.parent = gameObject.transform;

    }

    void Update()
    {
        if(timeCtrl==true)
        {
            spawnTime -= Time.deltaTime;
            if (spawnTime <= 0)
            {
                SpawnNewGem();
                spawnTime = 3;
                timeCtrl = false;     
                
            }
        }


    }


    
    public void SpawnNewGem()
    {
        newGem = Instantiate(gems[Random.Range(0, gems.Length)], transform.position + new Vector3(0, 0 + 0.35f, 0), Quaternion.identity);
        newGem.transform.parent = gameObject.transform;
        
    }
}
