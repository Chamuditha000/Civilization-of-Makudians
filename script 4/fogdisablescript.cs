using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogdisablescript : MonoBehaviour
{
public bool fogok;
    // Start is called before the first frame update
   private void Start()
    {
        fogok=RenderSettings.fog;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private void OnPreRender()
{
RenderSettings.fog=false;
}
private void OnPostRender()
{
RenderSettings.fog=fogok;
}

}
