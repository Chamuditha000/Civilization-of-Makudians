using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class snakegenberemu : MonoBehaviour
{public snakeAI sAI;
public float playertosafetree1distance;
public GameObject stree1;
public GameObject stree2;
public GameObject stree3;
public GameObject player;
public float playertosafetree2distance;
public float playertosafetree3distance;
public int lifeamount;
public GameObject safeplaceabsorbhealthnotifi;
    // Start is called before the first frame update
    void Start()
    {
        safeplaceabsorbhealthnotifi.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

lifeamount=PlayerPrefs.GetInt("lhealth");
playertosafetree1distance=Vector3.Distance(player.transform.position,stree1.transform.position);
playertosafetree2distance=Vector3.Distance(player.transform.position,stree2.transform.position);
playertosafetree3distance=Vector3.Distance(player.transform.position,stree3.transform.position);
if(playertosafetree1distance<=7f || playertosafetree2distance<=7f || playertosafetree3distance<=7f )

{
playerinasafeplace();
}
if(playertosafetree1distance>7f && playertosafetree2distance>7f && playertosafetree3distance>7f )

{
playernotinasafeplace();
}

        
    }
private void playerinasafeplace()
{
sAI.playeronsafe=true;
safeplaceabsorbhealthnotifi.gameObject.SetActive(true);
Invoke("closesplacenotifipanel",4f);
if(lifeamount>0)
{lifeamount-=1;
PlayerPrefs.SetInt("lhealth",lifeamount);}
}

private void playernotinasafeplace()
{
sAI.playeronsafe=false;
}

private void closesplacenotifipanel()
{
safeplaceabsorbhealthnotifi.gameObject.SetActive(false);
}
}
