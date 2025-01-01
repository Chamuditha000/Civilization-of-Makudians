using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shopmanager : MonoBehaviour
{public GameObject tentObject;
public Button buildbut;
public Button buybut;
public int camount;
public GameObject buylifemedguide;
public int tentbuilt;
public int tentbought;
public GameObject shopobject;
public int tentbuildfinished;
public int tentbuildfill;
public GameObject scrollbartent;
public int emptylm;
public int lmamt;
public Button buylmbut;
public Button filllmbut;
public int buybutlmoff;
public int fillstartlm;
public int filledlmedicine;
public int bouoghtlm;
public GameObject paliguobject;
public float playertomistcavedistance;
public int paligugot1st;
public Button buypaligu;
public Button addpaligubutton;
public int paligubought;
public GameObject mistcavepoint;
public GameObject player;
public int paliguadded;
public int paliguremoved;
public int boughtlmfirst;   
public int mission1ok;
public GameObject lifemedicineobjjj;
public GameObject mistcaveguideone;
public GameObject terriansafterm1;
public GameObject terriansafterm1block;
public GameObject removepaligubutton;
public GameObject shoppanel2;
public int m1seeobjectivesok;

    // Start is called before the first frame update
    void Start()
    {
shoppanel2.gameObject.SetActive(false);
removepaligubutton.gameObject.SetActive(false);
paliguobject.gameObject.SetActive(false);
shopobject.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
m1seeobjectivesok=PlayerPrefs.GetInt("seeobjectivesok");

if(m1seeobjectivesok==1)
{
shoppanel2.gameObject.SetActive(true);

}
if(m1seeobjectivesok==0)
{
shoppanel2.gameObject.SetActive(false);

}
camount=PlayerPrefs.GetInt("camt");


paliguadded=PlayerPrefs.GetInt("paligudamma");
paliguremoved=PlayerPrefs.GetInt("paliguaynkara");
playertomistcavedistance=Vector3.Distance(mistcavepoint.transform.position,player.transform.position);
paligubought=PlayerPrefs.GetInt("paligugaththa");
if(playertomistcavedistance<=12f && paligubought==0  )
{
mistcaveguideone.gameObject.SetActive(true);


}
if(playertomistcavedistance<=12f && paligubought==0 && camount>=1200 )
{
buypaligu.interactable=true;


}

if(playertomistcavedistance>12f || camount<1200 )
{

buypaligu.interactable=false;

}
if(playertomistcavedistance>12f )
{
mistcaveguideone.gameObject.SetActive(false);


}
if(paligubought==1)
{
mistcaveguideone.gameObject.SetActive(false);
buypaligu.interactable=false;
}
if(paligubought==1)
{
addpaligubutton.interactable=true;
buypaligu.interactable=false;
}
if(paligubought==0)
{
addpaligubutton.interactable=false;

}
if(paliguadded==1 && paliguremoved==0)
{
addpaligubutton.interactable=false;
paliguobject.gameObject.SetActive(true);
removepaligubutton.gameObject.SetActive(true);
}
if(paliguremoved==1 && paliguadded==0)
{
addpaligubutton.interactable=true;
paliguobject.gameObject.SetActive(false);
removepaligubutton.gameObject.SetActive(false);
}

lmamt=PlayerPrefs.GetInt("lifemamt");
emptylm=PlayerPrefs.GetInt("emptylifemedicine");
filledlmedicine=PlayerPrefs.GetInt("filledlm");
buybutlmoff=PlayerPrefs.GetInt("buybutlmclose");
fillstartlm=PlayerPrefs.GetInt("letsfilllm");
bouoghtlm=PlayerPrefs.GetInt("lifemedicinebought");
boughtlmfirst=PlayerPrefs.GetInt("lmboughtfirst");
mission1ok=PlayerPrefs.GetInt("missononecompleted");
if(boughtlmfirst==1)
{
lifemedicineobjjj.gameObject.SetActive(true);
}
if(boughtlmfirst==0)
{
lifemedicineobjjj.gameObject.SetActive(false);
}
if(bouoghtlm==1 && fillstartlm==0 && filledlmedicine==0 && emptylm==1 )
{
filllmbut.interactable=true;
}
if( filledlmedicine==1 || fillstartlm==1|| bouoghtlm==0 || emptylm==0)
{
filllmbut.interactable=false;
}


if(emptylm==1 && buybutlmoff==0)
{
bouoghtlm=0;
PlayerPrefs.SetInt("lifemedicinebought",bouoghtlm);



}


if(lmamt<100)
{
PlayerPrefs.SetInt("filledlm",0);
}
if(lmamt<=0)
{
PlayerPrefs.SetInt("emptylifemedicine",1);
}
if(lmamt>0)
{
PlayerPrefs.SetInt("emptylifemedicine",0);
}
if(mission1ok==1 && boughtlmfirst==0 )
{
buylifemedguide.gameObject.SetActive(true);
}
if( boughtlmfirst==1 )
{
buylifemedguide.gameObject.SetActive(false);
}
mission1ok=PlayerPrefs.GetInt("missononecompleted");
if( mission1ok==0 )
{
terriansafterm1block.gameObject.SetActive(true);
terriansafterm1.gameObject.SetActive(false);
buylifemedguide.gameObject.SetActive(false);

}
if( mission1ok==1 )
{
terriansafterm1.gameObject.SetActive(true);
terriansafterm1block.gameObject.SetActive(false);
}
if( bouoghtlm==0  && emptylm==1 && camount>=100 )
{
buylmbut.interactable= true;
}
if( bouoghtlm==1 || camount<100)
{
buylmbut.interactable= false;
}



if(fillstartlm==1   && filledlmedicine==0)
{
lmamt+=1;
PlayerPrefs.SetInt("lifemamt",lmamt);
if(lmamt>=100)
{
PlayerPrefs.SetInt("buybutlmclose",0);
PlayerPrefs.SetInt("filledlm",1);
PlayerPrefs.SetInt("letsfilllm",0);

}

}
camount=PlayerPrefs.GetInt("camt");


tentbuilt=PlayerPrefs.GetInt("tentbuildok");
tentbought=PlayerPrefs.GetInt("tentbuyok");
tentbuildfinished=PlayerPrefs.GetInt("tentok");

if(tentbuilt==0 )
{
scrollbartent.gameObject.SetActive(false);
tentObject.gameObject.SetActive(false);

}
if(tentbuilt==1 && tentbuildfinished ==0)
{
scrollbartent.gameObject.SetActive(true);
buildbut.interactable=false;    
tentbuildfill+=1;
PlayerPrefs.SetInt("tentbuild",tentbuildfill);
tentObject.gameObject.SetActive(false);


}

if(tentbuildfill>=1000)
{
buildfinishedtent();
 



}
if(tentbuilt==1 && tentbuildfinished ==1)
{
tentObject.gameObject.SetActive(true);
scrollbartent.gameObject.SetActive(false);
}
if(tentbuilt==0)
{
    tentObject.gameObject.SetActive(false);
buildbut.interactable=true;

}
if(tentbought==0)
{
   
buildbut.interactable=false;

}
if(tentbought==1)
{
buybut.interactable=false;   
buildbut.interactable=true;

}
if(camount>=500 && tentbought==0)
{
   
buybut.interactable=true;

}
if(camount<500 && tentbought==0 )
{
   
buybut.interactable=false;

}
if(tentbought==1 && tentbuilt==1)
{
   
buildbut.interactable=false;
buybut.interactable=false;

}
        
    }
public void buildtent()
{
 PlayerPrefs.SetInt("tentbuildok",1);


}
public void buytent()
{
 PlayerPrefs.SetInt("tentbuyok",1);
camount-=500;
PlayerPrefs.SetInt("camt",camount);


}

//buy medicineforrecover body
public void buylifemedicine()
{
PlayerPrefs.SetInt("lmboughtfirst",1);

PlayerPrefs.SetInt("buybutlmclose",1);
PlayerPrefs.SetInt("lifemedicinebought",1);
PlayerPrefs.SetInt("letsfilllm",0);
camount-=100;
PlayerPrefs.SetInt("camt",camount);


}
public void filllifemedicine()
{

PlayerPrefs.SetInt("letsfilllm",1);


}
public void shopopen()
{
shopobject.gameObject.SetActive(true);
Time.timeScale=0f;

 


}
public void shopclose()
{
shopobject.gameObject.SetActive(false);
Time.timeScale=1f;
 


}
private void buildfinishedtent()
{

PlayerPrefs.SetInt("tentok",1);
}
public void paligubuy()
{
PlayerPrefs.SetInt("paligugaththa",1);
camount=PlayerPrefs.GetInt("camt");
camount-=1200;
PlayerPrefs.SetInt("camt",camount);

}
public void addpaligu()
{
PlayerPrefs.SetInt("paligudamma",1);
PlayerPrefs.SetInt("paliguaynkara",0);

}
public void removepaligu()
{
PlayerPrefs.SetInt("paliguaynkara",1);
PlayerPrefs.SetInt("paligudamma",0);

}
public void earncoinsandlifeseeds()
{
SceneManager.LoadScene("in app scene");
}
}
