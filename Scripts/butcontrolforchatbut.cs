using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butcontrolforchatbut : MonoBehaviour
{
public GameObject cbut1;
public GameObject cbut2;
public GameObject chatofcom;
    // Start is called before the first frame update
    void Start()
    {
chatofcom.gameObject.SetActive(false);
        
    }
IEnumerator AutoScroll(ScrollRect scrollRect, float startPosition,float endPosition, float duration)
{ yield return new WaitForSeconds(0.5f);
float t0=0.0f;
while(t0 < 1.0f)
{
t0+=Time.deltaTime / duration;
scrollRect.verticalNormalizedPosition = Mathf.Lerp(startPosition,endPosition,t0);
yield return null;
}
}

    // Update is called once per frame
    void Update()
    {
        
    }
public void chatopenbutpress()
{
cbut1.gameObject.SetActive(false);
cbut2.gameObject.SetActive(true);
chatofcom.gameObject.SetActive(true);
StartCoroutine(AutoScroll(GameObject.Find("chatobject/chat panel/Scroll Viewnew").GetComponent<ScrollRect>(),1,0, 2f));

}
public void chatclosebutpress()
{
cbut1.gameObject.SetActive(true);
cbut2.gameObject.SetActive(false);
chatofcom.gameObject.SetActive(false);

}



}
