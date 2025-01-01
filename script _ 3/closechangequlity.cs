using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closechangequlity : MonoBehaviour
{
public GameObject panel;
public int changeqpok;

    // Start is called before the first frame update
    void Start()
    {
changeqpok=PlayerPrefs.GetInt("qualitychangepanelok");
if(changeqpok==0)
{
Invoke("closechangequliauto",25f);}

        
    }

    // Update is called once per frame
    void Update()
    {

        changeqpok=PlayerPrefs.GetInt("qualitychangepanelok");
if(changeqpok==0)
{
panel.gameObject.SetActive(true);
}
if(changeqpok==1)
{
panel.gameObject.SetActive(false);
}

    }

public void closechangequli()
{
PlayerPrefs.SetInt("qualitychangepanelok",1);
}

private void closechangequliauto()
{
PlayerPrefs.SetInt("qualitychangepanelok",1);
}
}
