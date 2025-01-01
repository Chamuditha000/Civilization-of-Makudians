using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptforstats : MonoBehaviour
{public Text highscoretxt; 
public Text longestruntxt; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      highscoretxt.text=PlayerPrefs.GetInt("highsco").ToString();
longestruntxt.text=PlayerPrefs.GetInt("longestrunn").ToString();  
    }
}
