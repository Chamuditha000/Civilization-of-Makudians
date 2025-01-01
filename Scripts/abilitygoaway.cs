using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilitygoaway : MonoBehaviour
{ public Image goawayfillimg;
public int Fillamtgoaway;
public float maxFillamtgoaway=10000.0f;
public float fillratiogoaway;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { fillratiogoaway=(Fillamtgoaway/maxFillamtgoaway);
Fillamtgoaway=PlayerPrefs.GetInt("shldabityamnt");
       goawayfillimg.fillAmount=fillratiogoaway; 
    }
}
