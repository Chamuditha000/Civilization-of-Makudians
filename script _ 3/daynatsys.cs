using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynatsys : MonoBehaviour
{public float timecom;
public float cometimee;
public int firststart;
public int timeset;
    // Start is called before the first frame update
    void Start()
    {
timecom=PlayerPrefs.GetFloat("timeofcom");
timeset=PlayerPrefs.GetInt("timesett");
//PlayerPrefs.SetInt("firststarttime",firststart);

if(timeset==0)
{

timecom=2400.0f;
PlayerPrefs.SetInt("timesett",1);

}
 

PlayerPrefs.SetFloat("timeofcom",timecom);


        
    }

    // Update is called once per frame
    void Update()
    {
timecom=PlayerPrefs.GetFloat("timeofcom");
      timecom+=Time.deltaTime;
PlayerPrefs.SetFloat("timeofcom",timecom); 
cometimee=timecom*12; 
    }
}
