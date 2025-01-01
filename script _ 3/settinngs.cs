using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class settinngs : MonoBehaviour
{
  // public AudioMixer audioMixer;
public int qualityval;
//public Dropdown dropd;

   void Start()
{
  
qualityval=PlayerPrefs.GetInt("qualityleveleka");
   QualitySettings.SetQualityLevel(qualityval);

//dropd.value=qualityval;

}
void Update(){
   qualityval=PlayerPrefs.GetInt("qualityleveleka");
}



   public void setqulity(int qualityIndex)
   {
   QualitySettings.SetQualityLevel(qualityIndex);
PlayerPrefs.SetInt("qualityleveleka",qualityIndex);
   }
 public void setqulitmy()
   {
   QualitySettings.SetQualityLevel(0);
   }

}
