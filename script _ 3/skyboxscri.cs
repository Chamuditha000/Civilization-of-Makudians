using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxscri : MonoBehaviour
{
     public Material mat1;

 public Material mat2;
public float timee;
void Update()

{timee=PlayerPrefs.GetInt("timeofcom");

if(timee==5700)
{
nighttt();
}
if(timee==1800)
{
dayyy();
}
}




private void nighttt(){

RenderSettings.skybox=mat2;

}
private void dayyy(){

RenderSettings.skybox=mat1;

}
}
