using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findgpstracker : MonoBehaviour
{
public GameObject mapmarkers;
public GameObject mapmarkerofplayer;
public GameObject darkforest;
public Transform PlayerTransform;
public float playertogpstdistance;
public GameObject pickbutpanelforgpstracker;
public int gpstgot;
public GameObject guidegpstrackerisnearby;
public int darkforestok;
public timeshow timeshowscri;
public int letsfindgpstracker;
public GameObject gpstopdui;
public Text ptogpsText;
public int playertogpsdint;
public int klemnaok;
public int sevenfoodsok;
public int magicplantok;
public GameObject gpstracker;
public int gpsttakingbutclicked;
public int darkforestcanseeok;
public int missononeokpanelcame;
public GameObject waituntill3daysguid;
public GameObject missononeokpanel;

    // Start is called before the first frame update
    void Start()
    {
missononeokpanel.gameObject.SetActive(false);
mapmarkers.gameObject.SetActive(false);
mapmarkerofplayer.gameObject.SetActive(false);
waituntill3daysguid.gameObject.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
missononeokpanelcame=PlayerPrefs.GetInt("m1okpcame");
gpstgot=PlayerPrefs.GetInt("gpstrackertook");
darkforestok=PlayerPrefs.GetInt("darkforestopen");
letsfindgpstracker = PlayerPrefs.GetInt("itsoktofindgpstracker");
gpsttakingbutclicked=PlayerPrefs.GetInt("gpstrackertakebutclickok");
klemnaok=PlayerPrefs.GetInt("drunkklemna");
sevenfoodsok=PlayerPrefs.GetInt("kaamahathamakaawa");
magicplantok=PlayerPrefs.GetInt("acdnclose");
darkforestcanseeok=PlayerPrefs.GetInt("darkforestseeok");
if(gpsttakingbutclicked==1)
{
gpstracker.gameObject.SetActive(false);
PlayerPrefs.SetInt("gpstrackertook",1);


}
if(gpstgot==1 && missononeokpanelcame==0)
{
missononeokpanel.gameObject.SetActive(true);
Invoke("closemoneokpanel",6.0f);
}
if( missononeokpanelcame==1)
{
missononeokpanel.gameObject.SetActive(false);

}






if(klemnaok==1 && sevenfoodsok==1 && magicplantok==1)
{
PlayerPrefs.SetInt("itsoktofindgpstracker",1);
}

playertogpstdistance= Vector3.Distance(gpstracker.transform.position,PlayerTransform.position);
playertogpsdint=(int)playertogpstdistance;
ptogpsText.text=playertogpsdint.ToString() + " m" ;

if(darkforestcanseeok==0 || playertogpstdistance>50.0f)
{
guidegpstrackerisnearby.gameObject.SetActive(false);
pickbutpanelforgpstracker.gameObject.SetActive(false);

}
if(darkforestcanseeok==1)
{
gpstopdui.gameObject.SetActive(true);
}
if(darkforestcanseeok==0)
{
gpstopdui.gameObject.SetActive(false);
}


if(gpstgot==1)
{
mapmarkers.gameObject.SetActive(true);
mapmarkerofplayer.gameObject.SetActive(true);

}
if(letsfindgpstracker==1 && timeshowscri.showdays<3)
{
waituntill3daysguid.gameObject.SetActive(true);


}
if(darkforestok==1)
{
darkforest.gameObject.SetActive(true);
PlayerPrefs.SetInt("darkforestseeok",1);
}
if(darkforestok==0)
{
darkforest.gameObject.SetActive(false);
}
if(timeshowscri.showdays>=1 && letsfindgpstracker==1)
{
PlayerPrefs.SetInt("darkforestopen",1);
waituntill3daysguid.gameObject.SetActive(false);
}


//findinggpstracker and picking it

//if player near to gpstracker let player know it 

//checking is player close to gpstracker
if(playertogpstdistance<=50 && gpstgot==0 && darkforestcanseeok==1)
{
guidegpstrackerisnearby.gameObject.SetActive(true);
}
if(gpstgot==1)
{
guidegpstrackerisnearby.gameObject.SetActive(false);
pickbutpanelforgpstracker.gameObject.SetActive(false);
gpstopdui.gameObject.SetActive(false);
PlayerPrefs.SetInt("missononecompleted",1);
}
//picking gps tracker
if(playertogpstdistance<=6.0f && gpstgot==0 && darkforestcanseeok==1)
{
pickbutpanelforgpstracker.gameObject.SetActive(true);
}

 
        
    }
//pickupbutton for pickup gpstracker
public void pickupgpstbut()
{
PlayerPrefs.SetInt("gpstrackertakebutclickok",1);

}
private void closemoneokpanel()
{


PlayerPrefs.SetInt("m1okpcame",1);
}
}
