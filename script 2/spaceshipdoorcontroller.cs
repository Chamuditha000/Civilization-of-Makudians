using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spaceshipdoorcontroller : MonoBehaviour
{

public GameObject spaceshipdoor;
public int keygot;
public GameObject player;
public Button keyui;
public Animator anim;
public GameObject closebut;
public float playertospaceshipdoordistance;
public GameObject triggerm2okobj;

    // Start is called before the first frame update
    void Start()
    {
      closebut.gameObject.SetActive(false); 
triggerm2okobj.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
keygot=PlayerPrefs.GetInt("keygotvalue");
playertospaceshipdoordistance=Vector3.Distance(player.transform.position,spaceshipdoor.transform.position);

if(playertospaceshipdoordistance<=10f && keygot==1)
{
keyui.interactable=true;

}
if(playertospaceshipdoordistance>12f && keygot==1)
{
keyui.interactable=false;


}

        
    }

public void openssdor()
{
anim.SetTrigger("opendoorofss");
closebut.gameObject.SetActive(true);
triggerm2okobj.gameObject.SetActive(true); 
Debug.Log("arima");

}

public void resetopen()
{
anim.ResetTrigger("opendoorofss");
anim.SetTrigger("closedoorofss");
closebut.gameObject.SetActive(false);
triggerm2okobj.gameObject.SetActive(false); 
}
}
