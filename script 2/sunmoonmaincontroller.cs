using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunmoonmaincontroller : MonoBehaviour
{public float dayoverrr;
public timeshow ts;
public int x;
public int lightset;
	Light myLight;

public float dayoverf;
    // Start is called before the first frame update
    void Start()
    {
myLight = GetComponent<Light>();
lightset=PlayerPrefs.GetInt("lightsetokmain");
myLight.intensity=PlayerPrefs.GetFloat("lightintensityvaluemain");
if(lightset==0)
{
myLight.intensity=0.8f;
PlayerPrefs.SetFloat("lightintensityvaluemain",myLight.intensity);
PlayerPrefs.SetInt("lightsetokmain",1);
}

      



    }

    // Update is called once per frame
    void Update()
    {
myLight = GetComponent<Light>();
myLight.intensity=PlayerPrefs.GetFloat("lightintensityvaluemain");
lightset=PlayerPrefs.GetInt("lightsetokmain");
if(lightset==0)
{
myLight.intensity=0.8f;
PlayerPrefs.SetFloat("lightintensityvaluemain",myLight.intensity);
PlayerPrefs.SetInt("lightsetokmain",1);
}


x=ts.showhours;




     
if(x>6 && x<=12)
   {
myLight.intensity+=0.0001f; 
PlayerPrefs.SetFloat("lightintensityvaluemain",myLight.intensity);
}
if(x>12 && x<=24)
   {
myLight.intensity-=0.00006f; 
PlayerPrefs.SetFloat("lightintensityvaluemain",myLight.intensity);
}
if(x>0 && x<=6)
   {
myLight.intensity=0.3f;
PlayerPrefs.SetFloat("lightintensityvaluemain",myLight.intensity);
 }


    }

}
