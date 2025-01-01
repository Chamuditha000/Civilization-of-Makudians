using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class snakeAI : MonoBehaviour
{
    Vector3 pos;
  Transform PlayerTransform;
Transform treeTransform;
Transform initialfirsttigerplace;
  NavMeshAgent myNavmesh;
  public bool following;
private float enemyrange=100f;
private float nearrange=20.0f;
public float pllayerdistancetoenemy;
public float initialplacetotigerfirstdistance;
public Animator animenemy;
//public Animator trybattack;
public bool tryattack;
public bool goaway;
public bool attack;
public bool controlled;
public bool playeronsafe;
//private static tigeranim tigeranimations;
 public bool followingip;
  void Start()
  { Vector3 pos = transform.position;
 //animenemy=GameObject.FindGameObjectWithTag("Player");
      PlayerTransform=GameObject.FindGameObjectWithTag("Player").transform;
//treeTransform=GameObject.FindGameObjectWithTag("snaketree").transform;
initialfirsttigerplace=GameObject.FindGameObjectWithTag("initialfirstsnakepotnormal").transform;
      pllayerdistancetoenemy = Vector3.Distance(this.transform.position,PlayerTransform.position);
      myNavmesh= gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
//tigeranimations=GameObject.FindObjectOfType<tigeranim>();
  }
  void Update()
  {// if(initialplacetotigerfirstdistance>=100.0f)
//{
//tigeranimations.relax=true;



//}


 var rigidbody =  GetComponent<Rigidbody>();
       pllayerdistancetoenemy = Vector3.Distance(this.transform.position,PlayerTransform.position);
initialplacetotigerfirstdistance = Vector3.Distance(this.transform.position,initialfirsttigerplace.position);



       if (pllayerdistancetoenemy<enemyrange  && initialplacetotigerfirstdistance <= 500.0f && !playeronsafe)
  {

      following=true;
  }
  if (pllayerdistancetoenemy>enemyrange  || goaway || initialplacetotigerfirstdistance>500.0f || playeronsafe)
  {

      following=false;

  }
if(initialplacetotigerfirstdistance>500.0f || playeronsafe)
{
 followingip=true;

}
else if(initialplacetotigerfirstdistance<=500.0f || !playeronsafe)
{
followingip=false;
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
if(attack)
{
    tryattack=false;
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
myNavmesh.speed=8f;

      }
      if(!tryattack)
      {
myNavmesh.stoppingDistance=5f;
myNavmesh.speed=16f;
      }
      if(attack)
  {

      myNavmesh.stoppingDistance=0f;
myNavmesh.speed=10f;
  }
if(initialplacetotigerfirstdistance > 100.0f)
{
myNavmesh.speed=1f;

}
 
if(followingip)
{
initialpotfollowing();


}
  }


  


private void followingplayer()
  {

      myNavmesh.transform.LookAt(PlayerTransform);
 myNavmesh.destination=PlayerTransform.position;
  }
private void initialpotfollowing()
  {

      myNavmesh.transform.LookAt(initialfirsttigerplace);
 myNavmesh.destination=initialfirsttigerplace.position;
  }
}
