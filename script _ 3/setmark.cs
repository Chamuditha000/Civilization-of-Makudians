using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setmark : MonoBehaviour
{
public int runamt;
public int Highscoreamtt;
public int herbs;
public int magicbottle;
public int minerals;
public int brainseedamt;
public int mark;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {runamt=PlayerPrefs.GetInt("metershasrun");
Highscoreamtt=PlayerPrefs.GetInt("highsco");
herbs=PlayerPrefs.GetInt("herbssave");
magicbottle=PlayerPrefs.GetInt("magicbottlessave");
minerals=PlayerPrefs.GetInt("mineralssave");
brainseedamt=PlayerPrefs.GetInt("brainseedssave");

mark=runamt+Highscoreamtt+(herbs*5)+(brainseedamt*100)+(magicbottle*60)+(minerals*10);
PlayerPrefs.SetInt("MOP",mark);
        
    }
}
