using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptofpropicone : MonoBehaviour
{public int propicvalue;
public GameObject profilepicset;
public int malev;
public int femalev;
public GameObject profilepicsetgirl;
    // Start is called before the first frame update
    void Start()
    {
profilepicset.gameObject.SetActive(false);
profilepicsetgirl.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {malev = PlayerPrefs.GetInt("male");
femalev=PlayerPrefs.GetInt("female");
        
    }
public void propiconebut()
{
//OfftheAllbuttons
profilepicset.gameObject.SetActive(false);
//savetheprofilepicturevalue
propicvalue=1;
PlayerPrefs.SetInt("prpicvlu",propicvalue);

}
public void propiconebutgirl()
{
//OfftheAllbuttons
profilepicsetgirl.gameObject.SetActive(false);
//savetheprofilepicturevalue
propicvalue=5;
PlayerPrefs.SetInt("prpicvlu",propicvalue);

}
public void propictwobut()
{
//OfftheAllbuttons
profilepicset.gameObject.SetActive(false);
//savetheprofilepicturevalue
propicvalue=2;
PlayerPrefs.SetInt("prpicvlu",propicvalue);

}
public void propictwobutgirl()
{
//OfftheAllbuttons
profilepicsetgirl.gameObject.SetActive(false);
//savetheprofilepicturevalue
propicvalue=6;
PlayerPrefs.SetInt("prpicvlu",propicvalue);

}
public void propicthreebut()
{
//OfftheAllbuttons
profilepicset.gameObject.SetActive(false);
//savetheprofilepicturevalue
propicvalue=3;
PlayerPrefs.SetInt("prpicvlu",propicvalue);

}
public void propicthreebutgirl()
{
//OfftheAllbuttons
profilepicsetgirl.gameObject.SetActive(false);
//savetheprofilepicturevalue
propicvalue=7;
PlayerPrefs.SetInt("prpicvlu",propicvalue);

}
public void propicfourbut()
{
//OfftheAllbuttons
profilepicset.gameObject.SetActive(false);
//savetheprofilepicturevalue
propicvalue=4;
PlayerPrefs.SetInt("prpicvlu",propicvalue);

}
public void propicfourbutgirl()
{
//OfftheAllbuttons
profilepicsetgirl.gameObject.SetActive(false);
//savetheprofilepicturevalue
propicvalue=8;
PlayerPrefs.SetInt("prpicvlu",propicvalue);

}
public void openthepropics()
{if(malev==1 && femalev==0)
//OfftheAllbuttons
{profilepicset.gameObject.SetActive(true);}
if(femalev==1 && malev==0)
//OfftheAllbuttons
{profilepicsetgirl.gameObject.SetActive(true);}

}
}
