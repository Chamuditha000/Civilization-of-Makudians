using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkforestaudio : MonoBehaviour
{
public AudioSource audios;
public float playertodarkforestcenterd;
public GameObject player;
public GameObject darkfcenter;
public bool played;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
playertodarkforestcenterd=Vector3.Distance(player.transform.position,darkfcenter.transform.position);
if(playertodarkforestcenterd<=600f && !played)
{
audios.Play();
played=true;
} 
if(playertodarkforestcenterd>600f)
{
audios.Stop();
played=false;
} 
        
    }
}
