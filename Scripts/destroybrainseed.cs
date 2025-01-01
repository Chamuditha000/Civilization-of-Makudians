using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybrainseed : MonoBehaviour
{
 public AudioClip brainseedaudio;
void Start()
{
//sourcee=GetComponent<AudioSource>();
}

    void OnTriggerEnter (Collider col)
	 {
	switch(col.gameObject.tag)
{
case "Player":
musicon();
pickpick();


break;

}
}
   
private void pickpick()
{
pickupamtshow.pickupobjfour +=1;
pickupsdatasave.savebrainseedsamt+=1;
Destroy(gameObject);
}
private void musicon()
{
AudioSource.PlayClipAtPoint(brainseedaudio,transform.position);
}
     
}
