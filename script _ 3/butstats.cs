using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butstats : MonoBehaviour
{public GameObject stats1;
public GameObject stats2;
public GameObject panelstats;
    // Start is called before the first frame update
    void Start()
    {
    panelstats.gameObject.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void pressstats2()
{
stats1.gameObject.SetActive(true);
stats2.gameObject.SetActive(false);
panelstats.gameObject.SetActive(false);
}
public void pressstats1()
{
stats1.gameObject.SetActive(false);
stats2.gameObject.SetActive(true);
panelstats.gameObject.SetActive(true);
}
}
