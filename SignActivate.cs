using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SignActivate : MonoBehaviour
{
    public GameObject sign1,sign2;
    // Start is called before the first frame update
    void Start()
    {
     sign1.SetActive(false);
     sign2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     StartCoroutine(ActivateSign());   
    }

    private void OnTriggerEnter(Collider col)
    {
     if (col.gameObject.tag == "Sign") 
     {
      sign2.SetActive(true);   
     }
    }
    IEnumerator ActivateSign()
    {
     yield return new WaitForSeconds(10);
     sign1.SetActive(true);
    }



}
