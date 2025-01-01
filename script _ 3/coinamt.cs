using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinamt : MonoBehaviour
{


int coinamount;
public Text camttext;
public int coinreset;

    // Start is called before the first frame update
    void Start()
    {
coinreset=PlayerPrefs.GetInt("camtreset");
if(coinreset==0)
{
PlayerPrefs.SetInt("camt",0);
PlayerPrefs.SetInt("camtreset",1);
}

        
    }

    // Update is called once per frame
    void Update()
    {


if(coinamount<0)
{
coinamount=0;
PlayerPrefs.SetInt("camt",coinamount);
}



coinamount=PlayerPrefs.GetInt("camt");

camttext.text=coinamount.ToString();

    }
}
