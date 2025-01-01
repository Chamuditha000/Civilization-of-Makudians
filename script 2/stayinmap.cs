using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stayinmap : MonoBehaviour
{
public Transform PlayerTransform;

public float MinimapSize;

public float Distance;
public bool inthemap;
public Vector3 vectorreduce;
    // Start is called before the first frame update
    void Start()
    {PlayerTransform=GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
vectorreduce=new Vector3(2,0,2);



 Distance= Vector3.Distance(this.transform.position,PlayerTransform.position);
if(Distance > MinimapSize)
{
inthemap=false;
 



}
if(!inthemap)
{
Vector3 fromOriginToObject = (this.transform.position - PlayerTransform.position)-vectorreduce  ;
transform.position = PlayerTransform.position + fromOriginToObject ;
inthemap=true;
}

        
    }


}
