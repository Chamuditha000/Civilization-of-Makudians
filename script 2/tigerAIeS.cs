using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class tigerAIeS : MonoBehaviour
{
    Vector3 pos;
  Transform PlayerTransform;
//Transform initialfirsttigerplace;
  NavMeshAgent myNavmesh;
  public bool following;
private float enemyrange=10000f;
private float nearrange=5f;
public float pllayerdistancetoenemy;
//public float initialplacetotigerfirstdistance;
public Animator animenemy;
//public Animator trybattack;
public bool tryattack;
public bool goaway;
public bool attack;
public bool controlled;
private static tigeranim tigeranimations;
  void Start()
  { Vector3 pos = transform.position;
 //animenemy=GameObject.FindGameObjectWithTag("Player");
      PlayerTransform=GameObject.FindGameObjectWithTag("Player").transform;
//initialfirsttigerplace=GameObject.FindGameObjectWithTag("initialfirsttigerpot").transform;
      pllayerdistancetoenemy = Vector3.Distance(this.transform.position,PlayerTransform.position);
      myNavmesh= gameObject.GetComponent<NavMeshAgent>();
tigeranimations=GameObject.FindObjectOfType<tigeranim>();
  }
  void Update()
  { //if(initialplacetotigerfirstdistance>=100.0f)
//{
//tigeranimations.relax=true;



//}


 var rigidbody =  GetComponent<Rigidbody>();
       pllayerdistancetoenemy = Vector3.Distance(this.transform.position,PlayerTransform.position);
//initialplacetotigerfirstdistance = Vector3.Distance(this.transform.position,initialfirsttigerplace.position);



       if (pllayerdistancetoenemy<enemyrange && nearrange<pllayerdistancetoenemy) //&& initialplacetotigerfirstdistance < 100.0f
  {

      following=true;
  }
  if (pllayerdistancetoenemy>enemyrange || nearrange>pllayerdistancetoenemy || goaway) //|| initialplacetotigerfirstdistance>=100.0f )
  {

      following=false;
  }
if(!controlled)
{
    goaway=false;
    
}

  
  if(nearrange>=pllayerdistancetoenemy)
  {tryattack=true;
if(controlled)
{
    goaway=true;
    attack=false;
}
if(!controlled)
{
    goaway=false;
    attack=true;
}

  }
  if(nearrange<pllayerdistancetoenemy)
  {
      tryattack=false;
  }


      if (following)
      {
          followingplayer();

      }

      if(tryattack)
      {
//animenemy.SetTrigger("tryattackattack");
myNavmesh.stoppingDistance=3f;
myNavmesh.speed=26.3f;

      }
      if(!tryattack && following)
      {
myNavmesh.stoppingDistance=5f;
myNavmesh.speed=26f;
      }
      if(attack)
  {

      myNavmesh.stoppingDistance=0f;
myNavmesh.speed=40f;
attack=false;
tryattack=false;
Invoke("afterattack",1f);
  }
//if(initialplacetotigerfirstdistance > 100.0f)
//{
//myNavmesh.speed=0f;
//}
  }

  


private void followingplayer()
  {

      myNavmesh.transform.LookAt(PlayerTransform);
 myNavmesh.destination=PlayerTransform.position;
  }
private void afterattack()
  {
myNavmesh.speed=5f;

     
  }
}
