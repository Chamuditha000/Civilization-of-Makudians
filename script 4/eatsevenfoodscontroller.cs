using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class eatsevenfoodscontroller : MonoBehaviour
{
public int foodoneeaten;
public int foodtwoeaten;
public int foodthreeeaten;
public int foodfoureaten;
public int foodfiveeaten;
public int foodsixeaten;
public int foodseveneaten;
public int foodoneok;
public int foodtwook;
public int foodthreeok;
public int foodfourok;
public int foodfiveok;
public int foodsixok;
public int foodsevenok;

public int foodoneonclickok;
public int foodtwoonclickok;
public int foodthreeonclickok;
public int foodfouronclickok;
public int foodfiveonclickok;
public int foodsixonclickok;
public int foodsevenonclickok;
public int sevenfoodseaten;
public int atleastboughtonefood;
public GameObject sevenfoodspanel;

public GameObject food1unit;
public GameObject food2unit;
public GameObject food3unit;
public GameObject food4unit;
public GameObject food5unit;
public GameObject food6unit;
public GameObject food7unit;
public Button foodeat1;
public Button foodeat2;
public Button foodeat3;
public Button foodeat4;
public Button foodeat5;
public Button foodeat6;
public Button foodeat7;
public Animator anim;
public Button buyfood1but;
public Button buyfood2but;
public Button buyfood3but;
public Button buyfood4but;
public Button buyfood5but;
public Button buyfood6but;
public Button buyfood7but;
public int coinamount;
public GameObject food1bottle;
public GameObject food2bottle;
public GameObject food3bottle;
public GameObject food4bottle;
public GameObject food5bottle;
public GameObject food6bottle;
public GameObject food7bottle;

    // Start is called before the first frame update
    void Start()
    {
        food1bottle.gameObject.SetActive(false);
	food2bottle.gameObject.SetActive(false);
	food3bottle.gameObject.SetActive(false);
	food4bottle.gameObject.SetActive(false);
	food5bottle.gameObject.SetActive(false);
	food6bottle.gameObject.SetActive(false);
	food7bottle.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
coinamount=PlayerPrefs.GetInt("camt");






//food1
if(coinamount>=50 && foodoneok==0)
{
    buyfood1but.interactable=true;
}
if(coinamount<50 && foodoneok==0)
{
    buyfood1but.interactable=false;
}



//food2
if(coinamount>=100 && foodtwook==0)
{
    buyfood2but.interactable=true;
}
if(coinamount<100 && foodtwook==0)
{
    buyfood2but.interactable=false;
}



//food3
if(coinamount>=200 && foodthreeok==0)
{
    buyfood3but.interactable=true;
}
if(coinamount<200 && foodthreeok==0)
{
    buyfood3but.interactable=false;
}





//food4
if(coinamount>=325 && foodfourok==0)
{
    buyfood4but.interactable=true;
}
if(coinamount<325 && foodfourok==0)
{
    buyfood4but.interactable=false;
}





//food5
if(coinamount>=500 && foodfiveok==0)
{
    buyfood5but.interactable=true;
}
if(coinamount<500 && foodfiveok==0)
{
    buyfood5but.interactable=false;
}




//food6
if(coinamount>=615 && foodsixok==0)
{
    buyfood6but.interactable=true;
}
if(coinamount<615 && foodsixok==0)
{
    buyfood6but.interactable=false;
}



//food7
if(coinamount>=1000 && foodsevenok==0)
{
    buyfood7but.interactable=true;
}
if(coinamount<1000 && foodsevenok==0)
{
    buyfood7but.interactable=false;
}




foodoneeaten=PlayerPrefs.GetInt("atefood1");
foodtwoeaten=PlayerPrefs.GetInt("atefood2");
foodthreeeaten=PlayerPrefs.GetInt("atefood3");
foodfoureaten=PlayerPrefs.GetInt("atefood4");
foodfiveeaten=PlayerPrefs.GetInt("atefood5");
foodsixeaten=PlayerPrefs.GetInt("atefood6");
foodseveneaten=PlayerPrefs.GetInt("atefood7");


foodoneok=PlayerPrefs.GetInt("boughtfood1");
foodtwook=PlayerPrefs.GetInt("boughtfood2");
foodthreeok=PlayerPrefs.GetInt("boughtfood3");
foodfourok=PlayerPrefs.GetInt("boughtfood4");
foodfiveok=PlayerPrefs.GetInt("boughtfood5");
foodsixok=PlayerPrefs.GetInt("boughtfood6");
foodsevenok=PlayerPrefs.GetInt("boughtfood7");


foodoneonclickok=PlayerPrefs.GetInt("onclickf1");
foodtwoonclickok=PlayerPrefs.GetInt("onclickf2");
foodthreeonclickok=PlayerPrefs.GetInt("onclickf3");
foodfouronclickok=PlayerPrefs.GetInt("onclickf4");
foodfiveonclickok=PlayerPrefs.GetInt("onclickf5");
foodsixonclickok=PlayerPrefs.GetInt("onclickf6");
foodsevenonclickok=PlayerPrefs.GetInt("onclickf7");

if(foodoneeaten==1 && foodtwoeaten==1 && foodthreeeaten==1 && foodfoureaten==1 && foodfiveeaten==1 && foodsixeaten==1 && foodseveneaten==1 )
{
PlayerPrefs.SetInt("kaamahathamakaawa",1);

}
if(foodoneok==1 || foodtwook==1 || foodthreeok==1 || foodfourok==1 || foodfiveok==1 || foodsixok==1 || foodsevenok==1 )
{
PlayerPrefs.SetInt("kaamaekakhrigaththa",1);

}
//showfoodsineatingpanelstart
if(foodoneok==1)
{
food1unit.gameObject.SetActive(true);
buyfood1but.interactable=false;

}
if(foodoneok==0)
{
food1unit.gameObject.SetActive(false);


}
if(foodtwook==1)
{
food2unit.gameObject.SetActive(true);
buyfood2but.interactable=false;
}
if(foodtwook==0)
{
food2unit.gameObject.SetActive(false);


}
//3
if(foodthreeok==1)
{
food3unit.gameObject.SetActive(true);
buyfood3but.interactable=false;
}
if(foodthreeok==0)
{
food3unit.gameObject.SetActive(false);


}
//4
if(foodfourok==1)
{
food4unit.gameObject.SetActive(true);
buyfood4but.interactable=false;
}
if(foodfourok==0)
{
food4unit.gameObject.SetActive(false);


}

//5
if(foodfiveok==1)
{
food5unit.gameObject.SetActive(true);
buyfood5but.interactable=false;
}
if(foodfiveok==0)
{
food5unit.gameObject.SetActive(false);


}

//6
if(foodsixok==1)
{
food6unit.gameObject.SetActive(true);
buyfood6but.interactable=false;
}
if(foodsixok==0)
{
food6unit.gameObject.SetActive(false);


}

//7
if(foodsevenok==1)
{
food7unit.gameObject.SetActive(true);
buyfood7but.interactable=false;
}
if(foodsevenok==0)
{
food7unit.gameObject.SetActive(false);


}



//showfoodsineatingpanelend

///////
//showfoodeatingbuttonsstart
if(foodoneonclickok==1)
{
foodeat1.gameObject.SetActive(true);


}
if(foodoneonclickok==0)
{
foodeat1.gameObject.SetActive(false);


}
if(foodtwoonclickok==1)
{
foodeat2.gameObject.SetActive(true);
}
if(foodtwoonclickok==0)
{
foodeat2.gameObject.SetActive(false);


}
//3
if(foodthreeonclickok==1)
{
foodeat3.gameObject.SetActive(true);
}
if(foodthreeonclickok==0)
{
foodeat3.gameObject.SetActive(false);


}
//4
if(foodfouronclickok==1)
{
foodeat4.gameObject.SetActive(true);
}
if(foodfouronclickok==0)
{
foodeat4.gameObject.SetActive(false);


}

//5
if(foodfiveonclickok==1)
{
foodeat5.gameObject.SetActive(true);
}
if(foodfiveonclickok==0)
{
foodeat5.gameObject.SetActive(false);


}

//6
if(foodsixonclickok==1)
{
foodeat6.gameObject.SetActive(true);
}
if(foodsixonclickok==0)
{
foodeat6.gameObject.SetActive(false);


}

//7
if(foodsevenonclickok==1)
{
foodeat7.gameObject.SetActive(true);
}
if(foodsevenonclickok==0)
{
foodeat7.gameObject.SetActive(false);


}



//showfoodsineatingpanelend



sevenfoodseaten=PlayerPrefs.GetInt("kaamahathamakaawa");
atleastboughtonefood=PlayerPrefs.GetInt("kaamaekakhrigaththa");

if(sevenfoodseaten==1)
{
sevenfoodspanel.gameObject.SetActive(false);
}
if(atleastboughtonefood==1 && sevenfoodseaten==0)
{
sevenfoodspanel.gameObject.SetActive(true);
}
if(atleastboughtonefood==0)
{
sevenfoodspanel.gameObject.SetActive(false);
}

/*
if(foodoneok==1)
{
food1.gameObject.SetActive(true);
}
if(foodtwook==1)
{
food2.gameObject.SetActive(true);
}
if(foodthreeok==1)
{
food3.gameObject.SetActive(true);
}
if(foodfourok==1)
{
food4.gameObject.SetActive(true);
}
if(foodfiveok==1)
{
food5.gameObject.SetActive(true);
}
if(foodsixok==1)
{
food6.gameObject.SetActive(true);
}
if(foodsevenok==1)
{
food7.gameObject.SetActive(true);
}
*/

if(foodoneeaten==1)
{
foodeat1.interactable=false;
}
if(foodtwoeaten==1)
{
foodeat2.interactable=false;
}
if(foodthreeeaten==1)
{
foodeat3.interactable=false;
}
if(foodfoureaten==1)
{
foodeat4.interactable=false;
}
if(foodfiveeaten==1)
{
foodeat5.interactable=false;
}
if(foodsixeaten==1)
{
foodeat6.interactable=false;
}
if(foodseveneaten==1)
{
foodeat7.interactable=false;
}
        
    }
public void buybuttonfood1()
{
PlayerPrefs.SetInt("boughtfood1",1);
coinamount-=50;
PlayerPrefs.SetInt("camt",coinamount);
}
public void buybuttonfood2()
{
PlayerPrefs.SetInt("boughtfood2",1);
coinamount-=100;
PlayerPrefs.SetInt("camt",coinamount);
}
public void buybuttonfood3()
{
PlayerPrefs.SetInt("boughtfood3",1);
coinamount-=200;
PlayerPrefs.SetInt("camt",coinamount);
}
public void buybuttonfood4()
{
PlayerPrefs.SetInt("boughtfood4",1);
coinamount-=325;
PlayerPrefs.SetInt("camt",coinamount);
}
public void buybuttonfood5()
{
PlayerPrefs.SetInt("boughtfood5",1);
coinamount-=500;
PlayerPrefs.SetInt("camt",coinamount);
}
public void buybuttonfood6()
{
PlayerPrefs.SetInt("boughtfood6",1);
coinamount-=615;
PlayerPrefs.SetInt("camt",coinamount);
}
public void buybuttonfood7()
{
PlayerPrefs.SetInt("boughtfood7",1);
coinamount-=1000;
PlayerPrefs.SetInt("camt",coinamount);

}


public  void onclickfood1()
{
PlayerPrefs.SetInt("onclickf1",1);
}
public void onclickfood2()
{
PlayerPrefs.SetInt("onclickf2",1);
}
public void onclickfood3()
{
PlayerPrefs.SetInt("onclickf3",1);
}
public void onclickfood4()
{
PlayerPrefs.SetInt("onclickf4",1);
}
public void onclickfood5()
{
PlayerPrefs.SetInt("onclickf5",1);
}
public void onclickfood6()
{
PlayerPrefs.SetInt("onclickf6",1);
}
public void onclickfood7()
{
PlayerPrefs.SetInt("onclickf7",1);
}

public void eatfood1()
{
food1bottle.gameObject.SetActive(true);
PlayerPrefs.SetInt("atefood1",1);
anim.SetTrigger("eating");
Invoke("bottlefalsef1",9f);
}
public void eatfood2()
{
food2bottle.gameObject.SetActive(true);
PlayerPrefs.SetInt("atefood2",1);
anim.SetTrigger("eating");
Invoke("bottlefalsef2",9f);
}
public void eatfood3()
{
food3bottle.gameObject.SetActive(true);
PlayerPrefs.SetInt("atefood3",1);
anim.SetTrigger("eating");
Invoke("bottlefalsef3",9f);
}
public void eatfood4()
{
food4bottle.gameObject.SetActive(true);
PlayerPrefs.SetInt("atefood4",1);
anim.SetTrigger("eating");
Invoke("bottlefalsef4",9f);
}
public void eatfood5()
{
food5bottle.gameObject.SetActive(true);
PlayerPrefs.SetInt("atefood5",1);
anim.SetTrigger("eating");
Invoke("bottlefalsef5",9f);
}
public void eatfood6()
{
food6bottle.gameObject.SetActive(true);
PlayerPrefs.SetInt("atefood6",1);
anim.SetTrigger("eating");
Invoke("bottlefalsef6",9f);
}
public void eatfood7()
{
food7bottle.gameObject.SetActive(true);
PlayerPrefs.SetInt("atefood7",1);
anim.SetTrigger("eating");
Invoke("bottlefalsef7",9f);

}
private void bottlefalsef1()
{
food1bottle.gameObject.SetActive(false);

}
private void bottlefalsef2()
{
food2bottle.gameObject.SetActive(false);

}
private void bottlefalsef3()
{
food3bottle.gameObject.SetActive(false);

}
private void bottlefalsef4()
{
food4bottle.gameObject.SetActive(false);

}
private void bottlefalsef5()
{
food5bottle.gameObject.SetActive(false);

}
private void bottlefalsef6()
{
food6bottle.gameObject.SetActive(false);

}
private void bottlefalsef7()
{
food7bottle.gameObject.SetActive(false);

}
}
