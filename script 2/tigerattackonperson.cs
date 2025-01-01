using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tigerattackonperson : MonoBehaviour
{ private int lifehealthnormal;
private Animator anim;
public GameObject panelofdeath;
public AudioSource Audioo;
public AudioSource audiom2passed;

public AudioSource Audioo2;
public int m2okend;
public int mission2hitok;
public GameObject missiontwocompletedpanel;
public int mission2ok;
public int keygot;
public int icecaveok;
public int cp2ok;

    // Start is called before the first frame update
    void Start()
    {
missiontwocompletedpanel.gameObject.SetActive(false);
       anim=gameObject.GetComponent<Animator>();
Invoke("playbackg2",2.0f); 
    }

    // Update is called once per framevoid OnTriggerEnter (Collider col)
void Update()
{
lifehealthnormal=PlayerPrefs.GetInt("lhealth");
if(lifehealthnormal<=0)
{checkdeathanddie();
PlayerPrefs.SetInt("lhealth",0);



}
keygot=PlayerPrefs.GetInt("keygotvalue");
m2okend=PlayerPrefs.GetInt("missiontwocompletedend");
mission2hitok=PlayerPrefs.GetInt("missiontwocompletedhit");
mission2ok=PlayerPrefs.GetInt("missiontwocompleted");
icecaveok=PlayerPrefs.GetInt("icecaveworkok");
cp2ok=PlayerPrefs.GetInt("cp2value");
if(mission2ok==1 && m2okend==1)
{
missiontwocompletedpanel.gameObject.SetActive(false);


}
if(mission2hitok==1 && keygot==1 && icecaveok==1 && cp2ok==1)
{
PlayerPrefs.SetInt("missiontwocompleted",1);


}
if(mission2ok==1 && m2okend==0)
{
missiontwocompletedpanel.gameObject.SetActive(true);
audiom2passed.Play();
Invoke("m2completedend",7f);

}

}

void OnTriggerEnter (Collider col)
{
switch(col.gameObject.tag)
{
//case "enemystatic":
//crash();


//break;
case "tiger":
tigerattacknormal();
Debug.Log("ii");

break;
case "magicforestentrancetrigger":
closeguidem2magicfentrance();
Debug.Log(".........");

break;
case "mission2end":
endingmission2();
Debug.Log("mission2end");

break;
case "fetosfmark":
setfirsttimeenteredtosf();
Debug.Log("ii");

break;
case "sharpice":
iceattack();
Debug.Log("ulice");

break;



case "snake":
snakeattack();
Debug.Log("snakehere");

break;
case "water":
watertouch();
Debug.Log("iii");

break;

case "cpone":
PlayerPrefs.SetInt("cp1value",1);
Debug.Log("cponeok");

break;
case "cptwotrigger":
PlayerPrefs.SetInt("cp2value",1);
Debug.Log("cptwook");

break;
case "cpnew01trigger":
PlayerPrefs.SetInt("cpnew01value",1);
Debug.Log("cpnew01ok");

break;
case "cpthreetrigger":
PlayerPrefs.SetInt("cp3value",1);
Debug.Log("cpthreeok");

break;
case "icecavetrigger01":
PlayerPrefs.SetInt("icecave01trigged",1);
Debug.Log("icecavetriggeroneok");

break;
case "icecavetrigger02":
PlayerPrefs.SetInt("icecave02trigged",1);
Debug.Log("ictriggertwook");

break;
case "icecavetrigger03":
PlayerPrefs.SetInt("icecave03trigged",1);
Debug.Log("ictriggerthreeok");

break;

//mistcave

case "mistcavetrigger01":
PlayerPrefs.SetInt("mistcave01trigged",1);
Debug.Log("mctriggeroneok");

break;
case "mistcavetrigger02":
PlayerPrefs.SetInt("mistcave02trigged",1);
Debug.Log("mctriggertwook");

break;
case "mistcavetrigger03":
PlayerPrefs.SetInt("mistcave03trigged",1);
Debug.Log("mctriggerthreeok");

break;




}

}

private void m2completedend()
{

PlayerPrefs.SetInt("missiontwocompletedend",1);


}
private void endingmission2()
{
  PlayerPrefs.SetInt("missiontwocompletedhit",1);
}




private void tigerattacknormal()
{

lifehealthnormal=PlayerPrefs.GetInt("lhealth");
if(lifehealthnormal>0)
{
anim.SetBool("injuredrun",true);
lifehealthnormal-=10;
PlayerPrefs.SetInt("lhealth",lifehealthnormal);
Invoke("stopdamagedrunning",2.0f);
}
if(lifehealthnormal<=0)
{checkdeathanddie();



}


} 

private void stopdamagedrunning()
{
anim.SetBool("injuredrun",false);

}
private void closeguidem2magicfentrance()
{
PlayerPrefs.SetInt("closed1findgsf",1);
PlayerPrefs.SetInt("cp0value",1);
}



private void checkdeathanddie()
{


anim.SetBool("injuredrun",false);
anim.SetTrigger("Deathnormal");
Invoke("stoptimee",4f);
Invoke("deathpanelll",4f);



}
private void stoptimee()
{
Time.timeScale=0f;


}
private void deathpanelll()
{
panelofdeath.gameObject.SetActive(true);


}

private void watertouch()
{
Audioo.Play();
}

private void playbackg2()
{
Audioo2.Play();
}
private void setfirsttimeenteredtosf()
{
PlayerPrefs.SetInt("ftenteredtosf",1);
}





private void snakeattack()
{
lifehealthnormal=PlayerPrefs.GetInt("lhealth");
if(lifehealthnormal>0)
{
anim.SetBool("injuredrun",true);
lifehealthnormal-=20;
PlayerPrefs.SetInt("lhealth",lifehealthnormal);
Invoke("stopdamagedrunning",2.0f);
}
if(lifehealthnormal<=0)
{checkdeathanddie();



}
}
private void iceattack()
{
lifehealthnormal=PlayerPrefs.GetInt("lhealth");
if(lifehealthnormal>0)
{
anim.SetBool("injuredrun",true);
lifehealthnormal-=150;
PlayerPrefs.SetInt("lhealth",lifehealthnormal);
Invoke("stopdamagedrunning",2.0f);
}
if(lifehealthnormal<=0)
{checkdeathanddie();



}
}
}
