using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abpanelcontorlingscript : MonoBehaviour
{
    public GameObject ab1;
public GameObject ab2;
public GameObject panelab;
    // Start is called before the first frame update
    void Start()
    {
    panelab.gameObject.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void pressab2()
{
ab1.gameObject.SetActive(true);
ab2.gameObject.SetActive(false);
panelab.gameObject.SetActive(false);
}
public void pressab1()
{
ab1.gameObject.SetActive(false);
ab2.gameObject.SetActive(true);
panelab.gameObject.SetActive(true);
}
}
