using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class absorbpp : MonoBehaviour
{
public int phealth;
private Animator anim;
public timeshow tshow;
public GameObject particlesys;
public int safevalue;
public float phealthf;
public float a;
public int pausedval;
public bool attackbyenviro;
public GameObject notifihealthdownobj;
    // Start is called before the first frame update
    void Start()
    {
notifihealthdownobj.gameObject.SetActive(false);


particlesys.gameObject.SetActive(false);
    //anim=gameObject.GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {safevalue=PlayerPrefs.GetInt("insafe");
phealth=PlayerPrefs.GetInt("lhealth");
pausedval=PlayerPrefs.GetInt("paused");
if(tshow.showdays<1 && a<=700 && pausedval==0)
{a+=0.1f;}
if(a>700)
{a=0;}
if((a>=45 && a<=50 ) || (a>=200 && a<=205 ) || (a>=380 && a<=385) || (a>=435 && a<=440 ) || (a>=500 && a<=505 ) || (a>=680 && a<=690) )
{
attackbyenviro=true;

}
else
{
attackbyenviro=false;

}


if((tshow.showhours>=18 && tshow.showhours<=23) && safevalue==0 && tshow.showdays<1 && attackbyenviro)
{
particlesys.gameObject.SetActive(true);
notifihealthdownobj.gameObject.SetActive(true);
phealthf=(float)phealth;
phealthf-=0.0004f;
phealth=(int)phealthf;
PlayerPrefs.SetInt("lhealth",phealth);

}

if((tshow.showhours<18 && tshow.showhours>=0) || safevalue==1 || tshow.showdays>1 || !attackbyenviro)
{
absorbfromplayerstop();
notifihealthdownobj.gameObject.SetActive(false);


}

        
    }
private void absorbfromplayer()
{

//anim.SetTrigger("absorbfromp");


}
private void absorbfromplayerstop()
{

//anim.SetTrigger("absorbfromp");
particlesys.gameObject.SetActive(false);
notifihealthdownobj.gameObject.SetActive(false);

}
}
