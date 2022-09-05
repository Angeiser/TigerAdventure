using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopAndPaws : MonoBehaviour
{
    public Transform pawPoint, pawPoint1, pawPoint2, pawPoint3, poopPoint;
    public GameObject paw, paw1, paw2, paw3, poop;
    private float timeWait;
    public float timeWaitToPrint = 3f;
    // Update is called once per frame
    void Start()
    {
     timeWait = timeWaitToPrint;  
    }
    void Update()
    {
     if (timeWait <= 0) 
     { 
      timeWait = timeWaitToPrint;
      StartCoroutine(Paw());
      StartCoroutine(Poops());
     }
     else 
     {
      timeWait -= Time.deltaTime; 
     }
    }
    void Paws() 
    {
     Instantiate(paw, pawPoint.transform.position, pawPoint.transform.rotation);
     Instantiate(paw1, pawPoint1.transform.position, pawPoint1.transform.rotation);
     Instantiate(paw2, pawPoint2.transform.position, pawPoint2.transform.rotation);
     Instantiate(paw3, pawPoint3.transform.position, pawPoint3.transform.rotation);
    }
    void Poop() 
    {
     Instantiate(poop, poopPoint.transform.position, poopPoint.transform.rotation);
    }
    IEnumerator Poops() 
    {
     yield return new WaitForSeconds(1);
     Poop();
    }
    IEnumerator Paw() 
    {
     yield return new WaitForSeconds(1);
     Paws(); 
    }
}
