using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class absorbfrommagicplant : MonoBehaviour
{
   public float magicplantpower;
public int magicppowerstarted;
public int magicplantpowergot;
public int inarea;
public Text absorbingtext;
public GameObject absorbingstatus;
public GameObject absorbbut;
public GameObject absorbcompletednotifi;
public int closeacdnoti;
public GameObject absorbingfillobj;



public GameObject particlesysfrommagicplant;

    // Start is called before the first frame update
    void Start()
    {
absorbcompletednotifi.gameObject.SetActive(false);
absorbingstatus.gameObject.SetActive(false);

    //anim=gameObject.GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
closeacdnoti=PlayerPrefs.GetInt("acdnclose");
magicplantpower=PlayerPrefs.GetFloat("magicpp");
inarea=PlayerPrefs.GetInt("inareaofmagicplant");
magicppowerstarted=PlayerPrefs.GetInt("magicpstart");
magicplantpowergot=PlayerPrefs.GetInt("magicplantpowerok");

if(magicppowerstarted==1 && magicplantpowergot==0 && inarea==1)
{
magicplantpower+=1f;
absorbingstatus.gameObject.SetActive(true);
absorbbut.gameObject.SetActive(false);
PlayerPrefs.SetFloat("magicpp",magicplantpower);

absorbingtext.text="-----absorbing------  \n please don't move";
particlesysfrommagicplant.gameObject.SetActive(true);
}

if(magicppowerstarted==0)
{
absorbingstatus.gameObject.SetActive(false);
particlesysfrommagicplant.gameObject.SetActive(false);


}
if(magicppowerstarted==1 && magicplantpowergot==0)
{
absorbingfillobj.gameObject.SetActive(true);


}
if( magicplantpowergot==1 || magicppowerstarted==0)
{
absorbingfillobj.gameObject.SetActive(false);


}
if(magicplantpower>=100.0f)
{
absorbingtext.text="absorbtion complete";
PlayerPrefs.SetInt("magicplantpowerok",1);
particlesysfrommagicplant.gameObject.SetActive(false);

}
if(magicplantpower>=100.0f || inarea==0)
{

particlesysfrommagicplant.gameObject.SetActive(false);
absorbingstatus.gameObject.SetActive(false);



}

if(magicplantpowergot==1 && closeacdnoti==0)
{


absorbcompletednotifi.gameObject.SetActive(true);
Invoke("closeacdnotifi",5.0f);



}
if( closeacdnoti==1)
{


absorbcompletednotifi.gameObject.SetActive(false);




}








        
    }
public void magicpptake()
{

PlayerPrefs.SetInt("magicpstart",1);

}
private void closeacdnotifi()
{
absorbcompletednotifi.gameObject.SetActive(false);
PlayerPrefs.SetInt("acdnclose",1);
}

//anim.SetTrigger("absorbfromp");


}
