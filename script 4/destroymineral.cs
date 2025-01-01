using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymineral : MonoBehaviour
{
 public AudioClip mineralaudio;

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
pickpicktwo();



break;

}
}
   
private void pickpicktwo()
{
pickupamtshow.pickupobjtwo +=1;
pickupsdatasave.savemineralsamt+=1;
Destroy(gameObject);
}
private void musicon()
{
AudioSource.PlayClipAtPoint(mineralaudio,transform.position);
}
     
}
