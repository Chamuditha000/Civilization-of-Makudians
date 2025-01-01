using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class controlenemyyy : MonoBehaviour
{
protected goawayabili econtrolbut;
protected tigerAIeS tigerr;
public GameObject sheild;
public int sheildabamt;


    
void Start()
{


sheild.gameObject.SetActive(false);
econtrolbut=FindObjectOfType<goawayabili>();
tigerr=FindObjectOfType<tigerAIeS>();

}


void Update()
{sheildabamt=PlayerPrefs.GetInt("shldabityamnt");
if(econtrolbut.Pressed && sheildabamt>0)
{
tigerr.controlled=true;
sheild.gameObject.SetActive(true);
sheildabamt-=1;
PlayerPrefs.SetInt("shldabityamnt",sheildabamt);
}
if(!econtrolbut.Pressed||sheildabamt<=0)
{
tigerr.controlled=false;
sheild.gameObject.SetActive(false);
}

}
}
