using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class choosecharacter : MonoBehaviourPunCallbacks
{Vector3 poscam;
  Vector3 offset;
  public GameObject camera;
  public GameObject player1;
   public GameObject player2;
    public GameObject playermin1;
     public GameObject playermin2;
      public GameObject player0;
  public int playerno;

   public GameObject toplayer0butl;
    public GameObject toplayer1butl;
     public GameObject toplayermin1butl;
      public GameObject toplayermin2butl;
        public GameObject toplayer2butr;
   public GameObject toplayer0butr;
    public GameObject toplayer1butr;
     public GameObject toplayermin1butr;
     public int choosedplayerno;
     public GameObject panelafterchoosed;
      public GameObject panel1;
     
      
    // Start is called before the first frame update
    void Start()
    {
       toplayer1butl.gameObject.SetActive(false);
       panelafterchoosed.SetActive(false);

 
 toplayer0butl.gameObject.SetActive(false);
  toplayermin1butl.gameObject.SetActive(true);
     toplayermin2butl.gameObject.SetActive(false);
       toplayer2butr.gameObject.SetActive(false);
   toplayer0butr.gameObject.SetActive(false);
 toplayer1butr.gameObject.SetActive(true);
      toplayermin1butr.gameObject.SetActive(false);


         poscam=camera.transform.position;
        offset= new Vector3(0,1,2);
    }

    // Update is called once per frame
    void Update()
    {
      choosedplayerno=PlayerPrefs.GetInt("choosedplayerno");
      if(playerno==2){
        poscam=player2.transform.position+offset;
        camera.transform.position=poscam;
    }
       if(playerno==1){
        poscam=player1.transform.position+offset;
        camera.transform.position=poscam;
    }
       if(playerno==0){
        poscam=player0.transform.position+offset;
        camera.transform.position=poscam;
    }
       if(playerno==-1){
        poscam=playermin1.transform.position+offset;
        camera.transform.position=poscam;
    }
       if(playerno==-2){
        poscam=playermin2.transform.position+offset;
        camera.transform.position=poscam;
    }
    }

    public void toplayer2(){
      playerno=2;
      
      toplayer1butl.gameObject.SetActive(true);

 
 toplayer0butl.gameObject.SetActive(false);
  toplayermin1butl.gameObject.SetActive(false);
     toplayermin2butl.gameObject.SetActive(false);
       toplayer2butr.gameObject.SetActive(false);
   toplayer0butr.gameObject.SetActive(false);
 toplayer1butr.gameObject.SetActive(false);
      toplayermin1butr.gameObject.SetActive(false);

    }
      public void toplayer1(){
      playerno=1;
      toplayer2butr.gameObject.SetActive(true);
      toplayer0butl.gameObject.SetActive(true);

      /////
            toplayer1butl.gameObject.SetActive(false);
 toplayermin1butl.gameObject.SetActive(false);
     toplayermin2butl.gameObject.SetActive(false);
       
   toplayer0butr.gameObject.SetActive(false);
 toplayer1butr.gameObject.SetActive(false);
      toplayermin1butr.gameObject.SetActive(false);
    }
        public void toplayer0(){
      playerno=0;
       toplayer1butr.gameObject.SetActive(true);
      toplayermin1butl.gameObject.SetActive(true);


      /////

            toplayer2butr.gameObject.SetActive(false);
      toplayer0butl.gameObject.SetActive(false);

   
            toplayer1butl.gameObject.SetActive(false);
 
     toplayermin2butl.gameObject.SetActive(false);
       
   toplayer0butr.gameObject.SetActive(false);
 
      toplayermin1butr.gameObject.SetActive(false);
    }
        public void toplayermin1(){
      playerno=-1;
       toplayer0butr.gameObject.SetActive(true);
      toplayermin2butl.gameObject.SetActive(true);


      /////

      toplayer1butr.gameObject.SetActive(false);
      toplayermin1butl.gameObject.SetActive(false);


      /////

            toplayer2butr.gameObject.SetActive(false);
      toplayer0butl.gameObject.SetActive(false);

   
            toplayer1butl.gameObject.SetActive(false);
 
    
       
  
 
      toplayermin1butr.gameObject.SetActive(false);
      
    }
        public void toplayermin2(){
      playerno=-2;
        toplayermin1butr.gameObject.SetActive(true);



        /////


               toplayer0butr.gameObject.SetActive(false);
      toplayermin2butl.gameObject.SetActive(false);


      /////

      toplayer1butr.gameObject.SetActive(false);
      toplayermin1butl.gameObject.SetActive(false);


      /////

            toplayer2butr.gameObject.SetActive(false);
      toplayer0butl.gameObject.SetActive(false);

   
            toplayer1butl.gameObject.SetActive(false);
 
    
       
  
 
      
      
    }
    public void selectplayer(){
    
        PlayerPrefs.SetInt("choosedplayerno",playerno);
        panelafterchoosed.SetActive(true);
         panel1.SetActive(false);
      
    }
    public void gotomultiplayerarea(){
     
PhotonNetwork.ConnectUsingSettings();
    }
    
     public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("multiplayer area");
    }
  
}
