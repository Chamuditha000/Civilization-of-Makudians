using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinandlifeseedsamtonshop : MonoBehaviour
{
public Text cointxt;
public Text lseedstxt;
public int camount;
public int lifeseedsamount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
camount=PlayerPrefs.GetInt("camt");
lifeseedsamount= PlayerPrefs.GetInt("lsamt");
        cointxt.text=camount.ToString();
lseedstxt.text=lifeseedsamount.ToString();
    }
}
