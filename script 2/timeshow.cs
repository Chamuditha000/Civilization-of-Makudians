using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeshow : MonoBehaviour
{public int showhours;
public int showminutes;
public float showminutesff;
public int showSeconds;
public float showSecondsff;
public float showhoursff;
public float showdaysff;
public int showdays;
public static daynatsys timescri;
public Text hourstxt;
public Text minutestxt;
public Text Secondstxt;
public int dayover;
public GameObject sunobj;
public GameObject moonobj;
public bool sun;
//public GameObject rewardpanel;
public float dayoverf;
public Text daynoText;
public GameObject dailyrewardonitheepanel;
    // Start is called before the first frame update
    void Start()
    {
//rewardpanel.gameObject.SetActive(false);
dailyrewardonitheepanel.gameObject.SetActive(false);
        timescri= GameObject.FindObjectOfType<daynatsys>();
dayover=PlayerPrefs.GetInt("night");
    }

    // Update is called once per frame
    void Update()
    {
showdaysff=timescri.cometimee/(3600*24);
showdays= (int)showdaysff;
      showhoursff=(timescri.cometimee-(showdays*24*3600))/3600;  
showhours = (int)showhoursff;
showminutesff = (timescri.cometimee-((showhours*3600)+(showdays*24*3600)))/60;
showminutes = (int)showminutesff;
showSecondsff = timescri.cometimee-((showhours*3600)+(showminutes*60)+(showdays*24*3600));
showSeconds = (int)showSecondsff;
hourstxt.text=showhours.ToString();
minutestxt.text=showminutes.ToString();
Secondstxt.text=showSeconds.ToString();



daynoText.text=(showdays +1).ToString();
if(showdays == 5)
{
 PlayerPrefs.SetInt("fivedaysover",1);

}

/*if(showhours==0 )
{
dailyrewardonitheepanel.gameObject.SetActive(true);
}*/
if(showhours>=6 && showhours<18)
{
sun=true;
}
else
{
sun=false;
}

if(sun)
{
sunobj.SetActive(true);
moonobj.SetActive(false);

}
if(!sun)
{
sunobj.SetActive(false);
moonobj.SetActive(true);
}





    }
/*public void yesrewardoni()
{
rewardpanel.gameObject.SetActive(true);
}
public void norewardonina()
{
dailyrewardonitheepanel.gameObject.SetActive(false);
}*/
}
