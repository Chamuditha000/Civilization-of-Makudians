using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autogenratingenemylive : MonoBehaviour
{
    public int spawnobjectssize;
public int spawnpointssize;
public GameObject[] spawnpoints;
public GameObject[] spawnobjects;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;i<spawnpointssize;i++)
{

int randomno=Random.Range(0,spawnobjectssize-1);
Instantiate(spawnobjects[randomno],spawnpoints[i].transform);
//GameObject go ;

//go.transform.position.x=spawnpoints[i].transform.position.x;
//go.transform.position.y=spawnpoints[i].transform.position.y;
//go.transform.position.z=spawnpoints[i].transform.position.z;
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
