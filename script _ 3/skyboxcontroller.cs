using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxcontroller : MonoBehaviour
{
public Material day;
public Material night;
public timeshow timeshoww;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
if(timeshoww.showhours>=6 && timeshoww.showhours<18)       
{RenderSettings.skybox=day;}
if(timeshoww.showhours>=18 || timeshoww.showhours<6)       
{RenderSettings.skybox=night;}



    }
}
