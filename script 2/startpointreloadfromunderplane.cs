using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startpointreloadfromunderplane : MonoBehaviour
{
public GameObject player;
public GameObject startpoint;
Vector3 playerpos;
Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
playerpos=player.transform.position;
startpos=startpoint.transform.position;

        
    }
void OnTriggerEnter (Collider col)
{
	switch(col.gameObject.tag)
{
case "Player":
playerpos=startpos;
player.transform.position=playerpos;
startpoint.transform.position=startpos;



break;

}
}

}
