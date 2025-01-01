using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class blacktigerAIscriptblackti : MonoBehaviour
{  Vector3 pos;
  Transform PlayerTransform;
  NavMeshAgent myNavmesh;
  public bool following;
private float enemyrange=100f;
private float nearrange=5f;
private float pllayerdistancetoenemy;
public Animator animenemy;
//public Animator trybattack;
public bool tryattack;
public bool goaway;
public bool attack;
public bool controlled;
  void Start()
  { Vector3 pos = transform.position;
 //animenemy=gameObject.GetComponent<Animator>();
      PlayerTransform=GameObject.FindGameObjectWithTag("Player").transform;
      pllayerdistancetoenemy = Vector3.Distance(this.transform.position,PlayerTransform.position);
      myNavmesh= gameObject.GetComponent<NavMeshAgent>();
  }
  void Update()
  {  var rigidbody =  GetComponent<Rigidbody>();
       pllayerdistancetoenemy = Vector3.Distance(this.transform.position,PlayerTransform.position);
       if (pllayerdistancetoenemy<enemyrange && nearrange<pllayerdistancetoenemy)
  {

      following=true;
  }
  if (pllayerdistancetoenemy>enemyrange || nearrange>pllayerdistancetoenemy || goaway)
  {

      following=false;
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
myNavmesh.speed=15f;

      }
      if(!tryattack)
      {
myNavmesh.stoppingDistance=5f;
myNavmesh.speed=8f;
      }
      if(attack)
  {

      myNavmesh.stoppingDistance=0f;
myNavmesh.speed=20f;
  }
  }

  

  private void followingplayer()
  {

      myNavmesh.transform.LookAt(PlayerTransform);
 myNavmesh.destination=PlayerTransform.position;
  }
}
