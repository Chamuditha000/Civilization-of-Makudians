using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigeranim : MonoBehaviour
{public bool relax;
private Animator animm;
    // Start is called before the first frame update
    void Start()
    {
      animm=gameObject.GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
if(relax)
{
animm.SetBool("relax",true);
}
        
    }
}
