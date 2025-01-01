using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smUIcontrolscri : MonoBehaviour
{public GameObject  UIofstartmenu;
int ok;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      ok=PlayerPrefs.GetInt("gensub");
     if (ok==1)
     { 
     UIofstartmenu.gameObject.SetActive(true);
     } 
     if (ok==0)
     { 
      UIofstartmenu.gameObject.SetActive(false);
     } 
    }
}
