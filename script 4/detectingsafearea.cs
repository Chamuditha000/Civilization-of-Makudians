using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectingsafearea : MonoBehaviour
{public bool insafezone;
Transform PlayerTransform;
public float Playertosafedistance;
public float safetoborderdistance=50.0f;
public int ptosafedint;
public GameObject youareinsafeareaui;
public int nightstayok;
public Text ptosafetext;

    // Start is called before the first frame update
    void Start()
    { PlayerTransform=GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {



nightstayok=PlayerPrefs.GetInt("nightstayplaceok");
Playertosafedistance=Vector3.Distance(this.transform.position,PlayerTransform.position);
if(Playertosafedistance<=safetoborderdistance)
{

insafezone=true;



}
if(Playertosafedistance>safetoborderdistance)
{

insafezone=false;



}
    if(insafezone)
{


PlayerPrefs.SetInt("insafe",1);



}  
    if(insafezone && nightstayok==1)
{
youareinsafeareaui.gameObject.SetActive(true);





} 


    if(!insafezone)
{


PlayerPrefs.SetInt("insafe",0);


} 
    if(!insafezone || nightstayok==0)
{
youareinsafeareaui.gameObject.SetActive(false);





} 
ptosafedint=(int)Playertosafedistance;
ptosafetext.text=ptosafedint+" m";

 
    }
}
