using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermotor : MonoBehaviour
{
private const float LANE_DISTANCE = 3.0f;
private const float TURN_SPEED = 0.05f;

private Animator anim;
public int abiliityfloatamt;
   //Movement
private int desiredLane=1;   //0=Left,1=middle,2=right
private CharacterController controller;
private float jumpForce = 10.0f;
private float gravity =18.0f;
public float verticalVelocity;
private float speed = 25.0f;
private float horzV;
public int lifehealth;
public int score;
public Text ScoreTextt;
public Text MeterTextt;
public int HighScore;
public int meters;
public Text HighScoreText;
public GameObject DeathPanel;
protected joybutforfloat floatbut;
protected highjump highjbut;
Vector3 pos;
public bool highjon=false;
public GameObject jumphighbutobj;
public AudioClip damagedsound;





 void Start()
{


 pos = transform.position;
//sourcee=GetComponent<AudioSource>();

lifehealth= 1000;
controller= GetComponent<CharacterController>();
anim= GetComponent<Animator>();
//checkdeathanddie();
DeathPanel.gameObject.SetActive(false);
floatbut=FindObjectOfType<joybutforfloat>();
highjbut=FindObjectOfType<highjump>();
}

private void Update()
{
	if(lifehealth<=0)
{
lifehealth=0;
checkdeathanddie();


}
//highjump


if(highjbut.Pressed && !highjon )
{
jumphigh();
highjon=true;



}

 if(!highjbut.Pressed && highjon  )
{
highjon=false;
jumphighcancel();
}




pos = transform.position;

//lifehealth=PlayerPrefs.GetInt("lhealth");

if(lifehealth<=0)
{
checkdeathanddie();
//Debug.Log("jk");
}
abiliityfloatamt=PlayerPrefs.GetInt("abfloatamt");
if(floatbut.Pressed && abiliityfloatamt>0 )
{
anim.SetTrigger("floatt");
abiliityfloatamt-=1;
PlayerPrefs.SetInt("abfloatamt",abiliityfloatamt);


}
abiliityfloatamt=PlayerPrefs.GetInt("abfloatamt");
 if(!floatbut.Pressed || abiliityfloatamt<=0 )
{
anim.SetTrigger("floatcancel");
}



//checkdeathanddie();


HighScore= PlayerPrefs.GetInt("highsco");
if(score>HighScore)
{
PlayerPrefs.SetInt("highsco",score);
}
meters= PlayerPrefs.GetInt("longestrunn");
if(score/10>meters)
{
PlayerPrefs.SetInt("longestrunn",score/10);
}
PlayerPrefs.SetInt("metershasrun",score/10);


score = ((int)controller.transform.position.z);
PlayerPrefs.SetInt("scoreamt",score);
ScoreTextt.text=score.ToString();
if(score==0)
{
MeterTextt.text=(0).ToString();
}
if(score!=0)
{MeterTextt.text=(((score/10)-1) + " " + "m").ToString();}
HighScoreText.text=HighScore.ToString();
//lifehealth= PlayerPrefs.GetInt("lhealth");

	
//if(MobileInput.Instance.SwipeLeft)
//MoveLaneLeft();
//move Left
//if(MobileInput.Instance.SwipeRight)
//move right
//MoveLaneRight();

//Vector3 targetPosition = transform.position.z * Vector3.forward;
//if(desiredLane == 0)
//targetPosition += Vector3.left * LANE_DISTANCE;
//else if(desiredLane == 2)
//targetPosition += Vector3.right * LANE_DISTANCE;

Vector3 moveVector = Vector3.zero;
if(MobileInput.Instance.SwipeLeft)
{horzV = -18.5f;
speed = 2.6f;
Invoke("changespeed",0.2f);}
if(MobileInput.Instance.SwipeRight)
{horzV = 18.5f;
speed = 2.6f;
Invoke("changespeed",0.2f);}
//(targetPosition-transform.position).normalized.x * speed;
bool isGrounded = IsGrounded();
anim.SetBool("Grounded",isGrounded);

if(isGrounded)
{



	if(MobileInput.Instance.SwipeUp)
	{
            anim.SetTrigger("Jump");
	verticalVelocity = jumpForce;
	}
      else if (MobileInput.Instance.SwipeDown)
	{
              anim.SetTrigger("slide");
	startsliding();
            Invoke("stopsliding", 1.0f);
	}
      else if (floatbut.Pressed && abiliityfloatamt>0)
      	 {
		verticalVelocity=5.0f;
		//pos.y=5.0f;
//transform.position = pos;
   	  }
       else
          {
            verticalVelocity =-0.1f;

          }



}









else
{
verticalVelocity -= (gravity * Time.deltaTime);
}

moveVector.x=horzV;
moveVector.y=verticalVelocity;
moveVector.z=speed;

controller.Move(moveVector * Time.deltaTime);
//rotate 
Vector3 dir = controller.velocity;
//if(dir != Vector3.zero)
//{
//dir.y=0;
//transform.forward = Vector3.Lerp(transform.forward,dir,TURN_SPEED);
//}

}
//private void MoveLane(bool goingRight)
//{if(goingRight)
//{desiredLane += 1;}
//else{
//desiredLane += -1;}
//desiredLane = Mathf.Clamp(desiredLane,0,2);
//}

private bool IsGrounded()
{
Ray groundRay = new Ray(new Vector3(controller.bounds.center.x,(controller.bounds.center.y- controller.bounds.extents.y) + 0.2f,controller.bounds.center.z),
Vector3.down);

return Physics.Raycast(groundRay,0.2f + 0.1f);


}
private void startsliding()
{
anim.SetBool("slide",true);
controller.height /= 2;
controller.center = new Vector3(controller.center.x,controller.center.y/2,controller.center.z);
}
private void stopsliding()
{
anim.SetBool("slide",false);
controller.height *= 2;
controller.center = new Vector3(controller.center.x,controller.center.y * 2,controller.center.z);
}
private void OnControllerColliderHit(ControllerColliderHit hit)
{
switch(hit.gameObject.tag)
{
case "enemystatic":
crash();


break;
case "tiger":
tigerattack();

break;



}

}

private void crash()
{


AudioSource.PlayClipAtPoint(damagedsound,transform.position);

//lifehealth=PlayerPrefs.GetInt("lhealth");
if(lifehealth>0)
{
anim.SetBool("Damagedrun",true);
lifehealth-=1;
//PlayerPrefs.SetInt("lhealth",lifehealth);
Invoke("stopdamagedrunning",2.0f);

}
if(lifehealth<=0)
{
checkdeathanddie();

}


}






private void stopdamagedrunning()
{
anim.SetBool("Damagedrun",false);

}


private void checkdeathanddie()
{


anim.SetBool("Damagedrun",false);
anim.SetTrigger("Death");
Invoke("stoptimee",2f);
Invoke("deathpanelll",2f);



}
private void stoptimee()
{
Time.timeScale=0f;

}
private void deathpanelll()
{

DeathPanel.gameObject.SetActive(true);
}
private void changespeed(){
speed = 25.0f;
horzV=0;}
private void tigerattack()
{
//lifehealth=PlayerPrefs.GetInt("lhealth");
if(lifehealth>0)
{
anim.SetBool("Damagedrun",true);
AudioSource.PlayClipAtPoint(damagedsound,transform.position);
lifehealth-=10;
//PlayerPrefs.SetInt("lhealth",lifehealth);
Invoke("stopdamagedrunning",2.0f);
}

}
public void runsaveme()
{
anim.SetTrigger("liveagainfromthedeathpoint");


}


private void jumphigh()
{
Time.timeScale+=1f;
}
private void jumphighcancel()
{
Time.timeScale-=1f;
}

}
