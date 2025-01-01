using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class afterdead : MonoBehaviour
{public int lifeam;
public GameObject podeath;
public Button rbut;
public int lifeseedsamount;
public GameObject recoveringbodypanel;
public GameObject shopobject;
public Text lifeseedsnotenoughtext;
public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
lifeam=PlayerPrefs.GetInt("lhealth");
        recoveringbodypanel.gameObject.SetActive(false);
       if(lifeam<=0)
        {
           Time.timeScale=0f;
            podeath.gameObject.SetActive(true);
        }
 if(lifeam>0)
        {
           
            podeath.gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
lifeam=PlayerPrefs.GetInt("lhealth");
if(lifeam>0)
        {
           
            podeath.gameObject.SetActive(false);
        }



lifeseedsamount=PlayerPrefs.GetInt("lsamt");
if(lifeseedsamount>=100)
{
  rbut.interactable=true;
}
if(lifeseedsamount<100)
{
  rbut.interactable=false;
lifeseedsnotenoughtext.text="you don't have enough lifeseeds to recover your body. please buy lifeseeds from shop.";
}



lifeam=PlayerPrefs.GetInt("lhealth");
        
    }
public void gotomenu()
{
SceneManager.LoadScene("start");

}
public void gotonormal()
{
SceneManager.LoadScene("playernormal scene");





}
public void recoverbody()
{
  recoveringbodypanel.gameObject.SetActive(true);


}
public void recoverbut()
{

lifeseedsamount=PlayerPrefs.GetInt("lsamt");
lifeam=PlayerPrefs.GetInt("lhealth");
  lifeam=500;
PlayerPrefs.SetInt("lhealth",lifeam);
lifeseedsamount-=100;
PlayerPrefs.SetInt("lsamt",lifeseedsamount);



recoveringbodypanel.gameObject.SetActive(false);
podeath.gameObject.SetActive(false);
Time.timeScale=1f;

anim.SetTrigger("recovered");
SceneManager.LoadScene("playernormal scene");

}
public void buylifeseeds()
{
SceneManager.LoadScene("in app scene");


}




}
