using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTiger : MonoBehaviour
{
    public GameObject tiger;
    // Start is called before the first frame update
    void Start()
    {
     tiger.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
     StartCoroutine(ACtivateTiger()); 
    }
    IEnumerator ACtivateTiger() 
    {
     yield return new WaitForSeconds(60);
     tiger.SetActive(true);
    }
}
