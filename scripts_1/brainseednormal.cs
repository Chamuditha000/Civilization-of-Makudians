using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainseednormal : MonoBehaviour
{
     void OnTriggerEnter (Collider col)
	 {
	switch(col.gameObject.tag)
{
case "Player":
pickpick();

break;

}
}
   
private void pickpick()
{

pickupsdatasave.savebrainseedsamt+=1;
Destroy(gameObject);
}
}
