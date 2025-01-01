using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivefromsnake : MonoBehaviour
{
public Transform PlayerTransform;
public float Playertosnakedistance;
public Transform snakeTransform;
    // Start is called before the first frame update
    void Start()
    {
     PlayerTransform=GameObject.FindGameObjectWithTag("Player").transform;
snakeTransform=GameObject.FindGameObjectWithTag("d1fm2").transform;   
    }

    // Update is called once per frame
    void Update()
    {
Playertosnakedistance=Vector3.Distance(snakeTransform.position,PlayerTransform.position);

if(Playertosnakedistance<=35.0f)
{
snakestartfollowingplayer();

}
if(Playertosnakedistance>35.0f)
{
snakestarttogoawayfromplayer();

}
        
    }
private void snakestartfollowingplayer()
{


}
private void snakestarttogoawayfromplayer()
{


}
}
