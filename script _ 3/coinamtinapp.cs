using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinamtinapp : MonoBehaviour
{
    public int coinamtt;
    public Text coinamttext;

    public int lsamtt;
    public Text lsamttext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinamtt=PlayerPrefs.GetInt("camt");
        coinamttext.text=coinamtt.ToString();

        lsamtt=PlayerPrefs.GetInt("lsamt");
        lsamttext.text=lsamtt.ToString();
    }
}
