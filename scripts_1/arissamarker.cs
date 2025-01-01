using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class arissamarker : MonoBehaviour
{
  public Image buildfill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
     buildfill.transform.position = namePos;
        
    }
}
