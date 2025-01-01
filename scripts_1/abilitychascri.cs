using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilitychascri : MonoBehaviour
{public int brainseedamt;
public int magicbottleamt;
public int herbsamt;
public int mineralsamt;
public int floatingamt;
public int shieldamt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
herbsamt=PlayerPrefs.GetInt("herbssave");
mineralsamt=PlayerPrefs.GetInt("mineralssave");
brainseedamt = PlayerPrefs.GetInt("brainseedssave");
magicbottleamt=PlayerPrefs.GetInt("magicbottlessave");

floatingamt=PlayerPrefs.GetInt("abfloatamt");

   shieldamt=PlayerPrefs.GetInt("shldabityamnt");     
    }
public void shieldup()
{shieldamt+=1;
PlayerPrefs.SetInt("shldabityamnt",shieldamt);
herbsamt-=2;
PlayerPrefs.SetInt("herbssave",herbsamt);
mineralsamt-=1;
PlayerPrefs.SetInt("mineralssave",mineralsamt);




}
public void floatingup()
{floatingamt+=1;
PlayerPrefs.SetInt("abfloatamt",floatingamt);
brainseedamt-=1;
PlayerPrefs.SetInt("brainseedssave",brainseedamt);
magicbottleamt-=1;
PlayerPrefs.SetInt("magicbottlessave",magicbottleamt);




}
}
