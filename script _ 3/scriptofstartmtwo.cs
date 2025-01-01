using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptofstartmtwo : MonoBehaviour
{
public GameObject missiontwoguideone;
public int missiononeok;
public Animator anim;
public int m2g1seeobjectivesok;
public int openedm2door1;
public bool neardoor1m2;
Transform PlayerTransform;
Transform d1fm2Transform;
public bool farfromdoor1fm2;
public GameObject guidem2findrockdoor;
public Text playertorockdoorduitext;

public GameObject cameram2begin;

public int closegd1sf;
public int Playertod1ofm2dint;
public int openg1d1sf;



public float Playertod1fm2distance;
public GameObject camm2beginpoint;
public float distanceforopendoor=10.0f;
public float distanceforclosedoor=45.0f;
public GameObject ptorddui;
public int firsttimeenteredtosf;
    // Start is called before the first frame update
    void Start()
    {
cameram2begin.gameObject.SetActive(false);

        PlayerTransform=GameObject.FindGameObjectWithTag("Player").transform;
d1fm2Transform=GameObject.FindGameObjectWithTag("d1fm2").transform;
    }

    // Update is called once per frame
    void Update()
    {
openg1d1sf=PlayerPrefs.GetInt("gsfd1open");
closegd1sf=PlayerPrefs.GetInt("closed1findgsf");
firsttimeenteredtosf=PlayerPrefs.GetInt("ftenteredtosf");


if(firsttimeenteredtosf==1 && openg1d1sf==1)
{
ptorddui.gameObject.SetActive(false);


}
if(firsttimeenteredtosf==0 && openg1d1sf==1)
{
ptorddui.gameObject.SetActive(true);


}
if(firsttimeenteredtosf==0 && openg1d1sf==0)
{
ptorddui.gameObject.SetActive(false);


}




playertorockdoorduitext.text=Playertod1ofm2dint.ToString() +" m";

openg1d1sf=PlayerPrefs.GetInt("gsfd1open");
closegd1sf=PlayerPrefs.GetInt("closed1findgsf");





Playertod1fm2distance=Vector3.Distance(d1fm2Transform.position,PlayerTransform.position);
Playertod1ofm2dint=(int)Playertod1fm2distance;

playertorockdoorduitext.text=Playertod1ofm2dint.ToString() +" m";
if(Playertod1fm2distance<=distanceforopendoor)
{

neardoor1m2=true;
farfromdoor1fm2=false;



}
if(Playertod1fm2distance>distanceforclosedoor)
{

farfromdoor1fm2=true;
neardoor1m2=false;



}
m2g1seeobjectivesok=PlayerPrefs.GetInt("seeobjectivesofm2ok");
openedm2door1=PlayerPrefs.GetInt("m2d1opened");
if(m2g1seeobjectivesok==1 && openedm2door1==0)
{
Invoke("rockdooropen",6.0f);
}
if(openedm2door1==1 && neardoor1m2)
{
anim.SetTrigger("m2rockdooroneopen");
anim.ResetTrigger("d1m2close");

}
if(openedm2door1==1 && farfromdoor1fm2)
{
anim.SetTrigger("d1m2close");
anim.ResetTrigger("m2rockdooroneopen");

}
missiononeok=PlayerPrefs.GetInt("missononecompleted");

if(missiononeok==1 && m2g1seeobjectivesok==0)
{
missiontwoguideone.gameObject.SetActive(true);
}

if(closegd1sf==0 && openg1d1sf==1)
{
guidem2findrockdoor.gameObject.SetActive(true);

}
if(closegd1sf==1 && openg1d1sf==1)
{
guidem2findrockdoor.gameObject.SetActive(false);

}
if(closegd1sf==0 && openg1d1sf==0)
{
guidem2findrockdoor.gameObject.SetActive(false);

}
        
    }


private void rockdooropen()
{
anim.SetTrigger("m2rockdooroneopen");
cameram2begin.gameObject.SetActive(true);

Invoke("cameraposreset",6.0f);
Invoke("dooropenreset",0.001f);
ptorddui.gameObject.SetActive(true);



PlayerPrefs.SetInt("m2d1opened",1);
}
private void cameraposreset()
{
cameram2begin.gameObject.SetActive(false);
guidem2findrockdoor.gameObject.SetActive(true);
PlayerPrefs.SetInt("gsfd1open",1);






}
private void dooropenreset()
{
anim.ResetTrigger("m2rockdooroneopen");
}
//public void closeguidespecialforestdfind()
//{
//PlayerPrefs.SetInt("closed1findgsf",1);


//}
}


