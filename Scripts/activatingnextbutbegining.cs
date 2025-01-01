using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatingnextbutbegining : MonoBehaviour
{ public GameObject activatebut; 

    // Start is called before the first frame update
    void Start()
    {activatebut.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {Invoke("activatenextbut",10);
    
        
    }
  private void activatenextbut(){

   activatebut.gameObject.SetActive(true);



}
}
