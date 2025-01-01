using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyherbs : MonoBehaviour
{public AudioClip herbsaudio;
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
pickpickone();


break;

}
}
   
private void pickpickone()
{
pickupamtshow.pickupobjone +=1;
pickupsdatasave.saveherbsamt+=1;
Destroy(gameObject);
}
private void musicon()
{
AudioSource.PlayClipAtPoint(herbsaudio,transform.position);
}
     
}
