using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymagicbottle : MonoBehaviour
{
public AudioClip magicbottleaudio;


void Start()
{
//sourcee=GetComponent<AudioSource>();
}
void update ()
{

}



    void OnTriggerEnter (Collider col)
	 {
	switch(col.gameObject.tag)
{
case "Player":
musicon();
pickpickthree();


break;

}
}
   
private void pickpickthree()
{
pickupamtshow.pickupobjthree +=1;
pickupsdatasave.savemagicbottlesamt+=1;
Destroy(gameObject);
//Invoke("createagain",5f);
}
private void musicon()
{
AudioSource.PlayClipAtPoint(magicbottleaudio,transform.position);
}

//private void createagain(){

//}
     
}
