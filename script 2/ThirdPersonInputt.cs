using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ThirdPersonInputt : MonoBehaviour
{
    private FixedJoystick LeftJoystick;
private FixedTouchField TouchField;
private FixedButton Button;
protected ThirdPersonUserControl Control;
protected float CameraAngle;
protected float CameraAngleSpeed=0.2f;

// Start is called before the first frame update
    void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>(); 
        LeftJoystick=FindObjectOfType<FixedJoystick>();
        TouchField=FindObjectOfType<FixedTouchField>();
        Button=FindObjectOfType<FixedButton>();
    }

    // Update is called once per frame
    void Update()
    {
     Control.m_Jump = Button.Pressed;
  Control.Hinput = LeftJoystick.inputVector.x;
        Control.Vinput = LeftJoystick.inputVector.y;  
CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;
Camera.main.transform.position= transform.position+ Quaternion.AngleAxis(CameraAngle,Vector3.up) * new Vector3(0,3,4); 
Camera.main.transform.rotation= Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position,Vector3.up);
    }
}
