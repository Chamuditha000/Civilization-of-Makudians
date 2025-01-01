using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllinginfoo : MonoBehaviour
{
public GameObject infoklemna;
    // Start is called before the first frame update
    void Start()
    {
    infoklemna.gameObject.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void loadinfoklemna()
{
infoklemna.gameObject.SetActive(true);
}
public void closeinfoklemna()
{
infoklemna.gameObject.SetActive(false);
}
}
