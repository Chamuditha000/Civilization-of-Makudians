using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlingmissions : MonoBehaviour
{
public GameObject mission1;
public GameObject mission2;
public GameObject mission3;
public int mission1completed;
public int mission2completed;
public int mission1show;
    // Start is called before the first frame update
    void Start()
    {
	mission1.gameObject.SetActive(false);
        mission2.gameObject.SetActive(false);
 mission3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
mission1show=PlayerPrefs.GetInt("seeobjectivesok");
mission1completed=PlayerPrefs.GetInt("missononecompleted");
mission2completed=PlayerPrefs.GetInt("missiontwocompleted");

if(mission2completed==1)

{
mission2.gameObject.SetActive(false);
mission3.gameObject.SetActive(true);
}


if(mission1completed==1 && mission2completed==0)
{
mission2.gameObject.SetActive(true);



}


if(mission1show==1 && mission1completed==0)
{
mission1.gameObject.SetActive(true);


}





if(mission1completed==1)

{
        mission1.gameObject.SetActive(false);
	
}
        
    }

}
