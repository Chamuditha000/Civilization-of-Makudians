using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drinkingklemna : MonoBehaviour
{

public GameObject klemnalittle;

public int playerhitklemnabox;
public int drinkclickok;

public GameObject drinkui;
public Animator anim;
public int drankok;
public int posokbottleover;
public float ptoklemnadistance;
public GameObject klemnadistanceui;
public int seeobjm1;
public int klemnadrinkover;
    // Start is called before the first frame update
    void Start()
    {
klemnalittle.gameObject.SetActive(false);
drinkui.gameObject.SetActive(false);
klemnadistanceui.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
seeobjm1=PlayerPrefs.GetInt("seeobjectivesok");


drankok=PlayerPrefs.GetInt("drank");
ptoklemnadistance =PlayerPrefs.GetFloat("ptoklemnad");



drinkclickok=PlayerPrefs.GetInt("drinkclicked");
klemnadrinkover=PlayerPrefs.GetInt("drunkklemna");
playerhitklemnabox = PlayerPrefs.GetInt("phitklemnabox");

//if player hits boxcolliders of klemna cube UI with drink but will appear
if(ptoklemnadistance<=1.0f && drinkclickok==0)
{
drinkui.gameObject.SetActive(true);

}
if(drinkclickok==1 && drankok==0)
{

klemnalittle.gameObject.SetActive(true);



//klemnatwo.gameObject.SetActive(true);
anim.SetTrigger("drinkklemna");

PlayerPrefs.SetInt("drank",1);
drinkui.gameObject.SetActive(false);
        
    }

if(drinkclickok==1 && klemnadrinkover==0  )
{

Invoke("stopdrinking",5.0f);
Invoke("drinkover",8.0f);


        
    }
if(drinkclickok==1)
{
klemnadistanceui.gameObject.SetActive(false);
}

if(klemnadrinkover==1)
{
klemnalittle.gameObject.SetActive(false);
klemnadistanceui.gameObject.SetActive(false);

        
    }
if(seeobjm1==1 && drinkclickok==0 && klemnadrinkover==0)
{
Invoke("distancetoklemnauiopen",10.0f);
}

}
public void drinkbutton()
{PlayerPrefs.SetInt("drinkclicked",1);
}
private void stopdrinking()
{anim.ResetTrigger("drinkklemna");
}
private void drinkover()
{

PlayerPrefs.SetInt("drunkklemna",1);
}

private void distancetoklemnauiopen()
{
klemnadistanceui.gameObject.SetActive(true);
}
}