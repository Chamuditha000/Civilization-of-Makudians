using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllingmap : MonoBehaviour
{
public Camera cam;
public GameObject spaceshipmarker;
public GameObject playermarker;
public mapcamcontroller zoomInbut;
public zoomoutmap zoomoutbut; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     if(zoomoutbut.Pressed && cam.orthographicSize<50)
{

cam.orthographicSize+=5;

spaceshipmarker.gameObject.transform.localScale+= new Vector3(2,2,2);
playermarker.gameObject.transform.localScale+= new Vector3(2,2,2);
}
   
if(zoomInbut.Pressed)
{
if(cam.orthographicSize>5)
{cam.orthographicSize-=5;}
if(spaceshipmarker.gameObject.transform.localScale.x>0 && spaceshipmarker.gameObject.transform.localScale.y>0 && spaceshipmarker.gameObject.transform.localScale.z>0)
{spaceshipmarker.gameObject.transform.localScale-= new Vector3(2,2,2);
playermarker.gameObject.transform.localScale-= new Vector3(2,2,2);}
}
    }
}
