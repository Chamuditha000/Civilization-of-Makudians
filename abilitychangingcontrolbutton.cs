using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class abilitychangingcontrolbutton : MonoBehaviour
{public Button sbut;
public Button fbut;
public int fbamt;
public int smamt;
public int fmbamt;
public int shamt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {fbamt=PlayerPrefs.GetInt("brainseedssave");
     smamt=PlayerPrefs.GetInt("mineralssave");
     fmbamt=PlayerPrefs.GetInt("magicbottlessave");
     shamt=PlayerPrefs.GetInt("herbssave");


if(fbamt>=1 && fmbamt>=1){
fbut.interactable=true;}
else{fbut.interactable=false;}

 
if(smamt>=1 && shamt>=2){
sbut.interactable=true;}
else{sbut.interactable=false;}


} 
        
    
}
