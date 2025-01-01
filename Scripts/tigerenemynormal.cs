using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class tigerenemynormal : MonoBehaviour
{
    Vector3 pos;
  Transform PlayerTransform;
Transform treeTransform;
Transform initialfirsttigerplace;
  NavMeshAgent myNavmesh;
  public bool following;
public GameObject blockpanel2;
public int sevenfoodswadeok;
public GameObject blockpanel;
private float enemyrange=100f;
private float nearrange=5f;
public float pllayerdistancetoenemy;
public float initialplacetotigerfirstdistance;
public Animator animenemy;
//public Animator trybattack;
public bool tryattack;
public bool goaway;
public bool attack;
public bool controlled;
private static tigeranim tigeranimations;
 public bool followingtree;
public int atleastboughtonefood;
  void Start()
  {
blockpanel.gameObject.SetActive(false);
blockpanel2.gameObject.SetActive(false);
 Vector3 pos = transform.position;
 //animenemy=GameObject.FindGameObjectWithTag("Player");
      PlayerTransform=GameObject.FindGameObjectWithTag("Player").transform;
treeTransform=GameObject.FindGameObjectWithTag("tigertree").transform;
initialfirsttigerplace=GameObject.FindGameObjectWithTag("initialfirsttigerpotnormal").transform;
      pllayerdistancetoenemy = Vector3.Distance(this.transform.position,PlayerTransform.position);
      myNavmesh= gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
tigeranimations=GameObject.FindObjectOfType<tigeranim>();
  }
  void Update()
  {// if(initialplacetotigerfirstdistance>=100.0f)
//{
//tigeranimations.relax=true;



//}


 var rigidbody =  GetComponent<Rigidbody>();
       pllayerdistancetoenemy = Vector3.Distance(this.transform.position,PlayerTransform.position);
initialplacetotigerfirstdistance = Vector3.Distance(this.transform.position,initialfirsttigerplace.position);

//blockpanel2
sevenfoodswadeok=PlayerPrefs.GetInt("kaamahathamakaawa");
 if (sevenfoodswadeok==1 || pllayerdistancetoenemy>110.0f)
      {
         

blockpanel2.gameObject.SetActive(false);

      }
sevenfoodswadeok=PlayerPrefs.GetInt("kaamahathamakaawa");
atleastboughtonefood=PlayerPrefs.GetInt("kaamaekakhrigaththa");


if(atleastboughtonefood==1 && sevenfoodswadeok==0 && pllayerdistancetoenemy<=110.0f)
{
blockpanel2.gameObject.SetActive(true);
}
if(atleastboughtonefood==0)
{
blockpanel2.gameObject.SetActive(false);
}
//blockpanel2



       if (pllayerdistancetoenemy<enemyrange && nearrange<pllayerdistancetoenemy )
  {

      following=true;
  }
  if (pllayerdistancetoenemy>enemyrange || nearrange>pllayerdistancetoenemy || goaway || initialplacetotigerfirstdistance>100.0f && pllayerdistancetoenemy>enemyrange )
  {

      following=false;

  }
if( pllayerdistancetoenemy>enemyrange)
{
 followingtree=true;
}
else if(  pllayerdistancetoenemy<=enemyrange)
{
followingtree=false;
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
  {tryattack=false;
attack=false;


  }
  if(nearrange<pllayerdistancetoenemy)
  {
      tryattack=false;
  }


      if (following)
      {
          followingplayer();
blockpanel.gameObject.SetActive(true);

      }
 if (!following)
      {
         
blockpanel.gameObject.SetActive(false);

      }


      if(tryattack)
      {
//animenemy.SetTrigger("tryattackattack");
myNavmesh.stoppingDistance=3f;
myNavmesh.speed=10f;


      }
      if(!tryattack)
      {
myNavmesh.stoppingDistance=5f;
myNavmesh.speed=8f;
      }
      if(attack)
  {

      myNavmesh.stoppingDistance=0f;
myNavmesh.speed=14f;
  }
if(initialplacetotigerfirstdistance > 100.0f)
{
myNavmesh.speed=1f;

}
 
if(followingtree)
{
treefollowing();


}
  }


  


private void followingplayer()
  {

      myNavmesh.transform.LookAt(PlayerTransform);
 myNavmesh.destination=PlayerTransform.position;
  }
private void treefollowing()
  {

      myNavmesh.transform.LookAt(treeTransform);
 myNavmesh.destination=treeTransform.position;
  }
}
