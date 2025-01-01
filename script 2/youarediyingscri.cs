using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youarediyingscri : MonoBehaviour
{
public GameObject  youarediyingpanel;
public int lifehealth;
public GameObject player;
public float playertosfdoor1distance;
public GameObject sfd1;
    // Start is called before the first frame update
    void Start()
    {
        youarediyingpanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
playertosfdoor1distance=Vector3.Distance(player.transform.position,sfd1.transform.position);

lifehealth=PlayerPrefs.GetInt("lhealth");

if(playertosfdoor1distance<14f)
{
 youarediyingpanel.gameObject.SetActive(true);




}
if(playertosfdoor1distance>=14f)
{
 youarediyingpanel.gameObject.SetActive(false);




}

        
    }
}
