using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilityfloatshowww : MonoBehaviour
{
     public Image floatingfillimg;
public int Fillamtfloating;
public float maxFillamtfloating=10000.0f;
public float fillratiofloating;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { fillratiofloating=(Fillamtfloating/maxFillamtfloating);
Fillamtfloating=PlayerPrefs.GetInt("abfloatamt");
       floatingfillimg.fillAmount=fillratiofloating; 
    }
}
