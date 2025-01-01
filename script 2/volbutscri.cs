using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volbutscri : MonoBehaviour
{
public GameObject volbut1;
public GameObject volbut2;
public GameObject panelvol;


    // Start is called before the first frame update
    void Start()
    {
panelvol.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void pressvolbut2()
{
volbut1.gameObject.SetActive(true);
volbut2.gameObject.SetActive(false);
panelvol.gameObject.SetActive(false);
}
public void pressvolbut1()
{
volbut1.gameObject.SetActive(false);
volbut2.gameObject.SetActive(true);
panelvol.gameObject.SetActive(true);
}


}
