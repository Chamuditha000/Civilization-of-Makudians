using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EItemstobodymanager : MonoBehaviour
{
public GameObject hat1;
public int camount;

public GameObject hat2;
public GameObject hat3;
public int hatchangevalue;
public GameObject pendent1;
public GameObject pendent2;
public GameObject pendent3;
public GameObject skirt1;
public GameObject skirt2;
public GameObject skirt3;

public GameObject cloak1;
public GameObject cloak2;
public GameObject cloak3;

public GameObject cloak0;
public GameObject skirt0;
public GameObject pendent0;

public int cloakchangevalue;
public int skirtchangevalue;
public int bodychangevalue;
public int pendentchangevalue;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
camount=PlayerPrefs.GetInt("camt");
hatchangevalue=PlayerPrefs.GetInt("hatchange");
    


 if(hatchangevalue==1)
{

hat1.gameObject.SetActive(true);
hat2.gameObject.SetActive(false);
hat3.gameObject.SetActive(false);

}
     if(hatchangevalue==2)
{

hat1.gameObject.SetActive(false);
hat2.gameObject.SetActive(true);
hat3.gameObject.SetActive(false);

}
     if(hatchangevalue==3)
{

hat1.gameObject.SetActive(false);
hat2.gameObject.SetActive(false);
hat3.gameObject.SetActive(true);

}

//cloak

cloakchangevalue=PlayerPrefs.GetInt("cloakchange");
     
     if(cloakchangevalue==0)
{
cloak0.gameObject.SetActive(true);
cloak1.gameObject.SetActive(false);
cloak2.gameObject.SetActive(false);
cloak3.gameObject.SetActive(false);

}

if(cloakchangevalue==1)
{
cloak0.gameObject.SetActive(false);
cloak1.gameObject.SetActive(true);
cloak2.gameObject.SetActive(false);
cloak3.gameObject.SetActive(false);

}

if(cloakchangevalue==2)
{cloak0.gameObject.SetActive(false);
cloak1.gameObject.SetActive(false);
cloak2.gameObject.SetActive(true);
cloak3.gameObject.SetActive(false);

}

if(cloakchangevalue==3)
{cloak0.gameObject.SetActive(false);
cloak1.gameObject.SetActive(false);
cloak2.gameObject.SetActive(false);
cloak3.gameObject.SetActive(true);

}


//pendent

pendentchangevalue=PlayerPrefs.GetInt("pendentchange");
     

 if(pendentchangevalue==0)
{
pendent0.gameObject.SetActive(true);
pendent1.gameObject.SetActive(false);
pendent2.gameObject.SetActive(false);
pendent3.gameObject.SetActive(false);

}
if(pendentchangevalue==1)
{pendent0.gameObject.SetActive(false);
pendent1.gameObject.SetActive(true);
pendent2.gameObject.SetActive(false);
pendent3.gameObject.SetActive(false);

}

if(pendentchangevalue==2)
{pendent0.gameObject.SetActive(false);
pendent1.gameObject.SetActive(false);
pendent2.gameObject.SetActive(true);
pendent3.gameObject.SetActive(false);

}

if(pendentchangevalue==3)
{pendent0.gameObject.SetActive(false);
pendent1.gameObject.SetActive(false);
pendent2.gameObject.SetActive(false);
pendent3.gameObject.SetActive(true);

}

//skirt

skirtchangevalue=PlayerPrefs.GetInt("skirtchange");
     

     if(skirtchangevalue==0)
{skirt0.gameObject.SetActive(true);
skirt1.gameObject.SetActive(false);
skirt2.gameObject.SetActive(false);
skirt3.gameObject.SetActive(false);

}
if(skirtchangevalue==1)
{skirt0.gameObject.SetActive(false);
skirt1.gameObject.SetActive(true);
skirt2.gameObject.SetActive(false);
skirt3.gameObject.SetActive(false);

}

if(skirtchangevalue==2)
{skirt0.gameObject.SetActive(false);
skirt1.gameObject.SetActive(false);
skirt2.gameObject.SetActive(true);
skirt3.gameObject.SetActive(false);

}

if(skirtchangevalue==3)
{skirt0.gameObject.SetActive(false);
skirt1.gameObject.SetActive(false);
skirt2.gameObject.SetActive(false);
skirt3.gameObject.SetActive(true);

}

/*
//hat1buybut
if(camount>50 && tentok==1)
{
hat1buybut.interactable=true;
}
if(camount<50 || tentok==0)
{
hat1buybut.interactable=false;
}

//hat2buybut
if(camount>150 && tentok==1)
{
hat2buybut.interactable=true;
}
if(camount<150 || tentok==0)
{
hat2buybut.interactable=false;
}

//hat3buybut
if(camount>360 && m1ok==1)
{
hat3buybut.interactable=true;
}
if(camount<360 || m1ok==0)
{
hat3buybut.interactable=false;
}


//skirt1buybut
if(camount>100 && magicplantok==1)
{
skirt1buybut.interactable=true;
}
if(camount<100 || magicplantok==0)
{
skirt1buybut.interactable=false;
}

//skirt2buybut
if(camount>250 && rockdoorm2ok==1)
{
skirt2buybut.interactable=true;
}
if(camount<250 || rockdoorm2ok==0)
{
skirt2buybut.interactable=false;
}

//skirt3buybut
if(camount>360 && m1ok==1)
{
hat3buybut.interactable=true;
}
if(camount<150 || tentok==0)
{
hat3buybut.interactable=false;
}*/
   
    }

//value one 
public void hatchange1()
{
PlayerPrefs.SetInt("hatchange",1);
camount-=50;
PlayerPrefs.SetInt("camt",camount);

}
public void skirtchange1()
{
PlayerPrefs.SetInt("skirtchange",1);
camount-=100;
PlayerPrefs.SetInt("camt",camount);

}

public void pendentchange1()
{
PlayerPrefs.SetInt("pendentchange",1);
camount-=500;
PlayerPrefs.SetInt("camt",camount);

}
public void cloakchange1()
{
PlayerPrefs.SetInt("cloakchange",1);
camount-=150;
PlayerPrefs.SetInt("camt",camount);

}

//value two 
public void hatchange2()
{
PlayerPrefs.SetInt("hatchange",2);
camount-=150;
PlayerPrefs.SetInt("camt",camount);

}
public void skirtchange2()
{
PlayerPrefs.SetInt("skirtchange",2);
camount-=250;
PlayerPrefs.SetInt("camt",camount);

}

public void pendentchange2()
{
PlayerPrefs.SetInt("pendentchange",2);
camount-=1000;
PlayerPrefs.SetInt("camt",camount);

}
public void cloakchange2()
{
PlayerPrefs.SetInt("cloakchange",2);
camount-=280;
PlayerPrefs.SetInt("camt",camount);

}



//value three 
public void hatchange3()
{
PlayerPrefs.SetInt("hatchange",3);
camount-=360;
PlayerPrefs.SetInt("camt",camount);

}
public void skirtchange3()
{
PlayerPrefs.SetInt("skirtchange",3);
camount-=500;
PlayerPrefs.SetInt("camt",camount);

}

public void pendentchange3()
{
PlayerPrefs.SetInt("pendentchange",3);
camount-=2000;
PlayerPrefs.SetInt("camt",camount);

}
public void cloakchange3()
{
PlayerPrefs.SetInt("cloakchange",3);
camount-=715;
PlayerPrefs.SetInt("camt",camount);

}


//value zero 



public void cloakchange0()
{
PlayerPrefs.SetInt("cloakchange",0);

PlayerPrefs.SetInt("camt",camount);

}
public void skirtchange0()
{
PlayerPrefs.SetInt("skirtchange",0);

PlayerPrefs.SetInt("camt",camount);


}



public void pendentchange0()
{
PlayerPrefs.SetInt("pendentchange",0);
camount-=200;
PlayerPrefs.SetInt("camt",camount);

}
}
