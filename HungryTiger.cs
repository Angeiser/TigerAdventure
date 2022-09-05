using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungryTiger : MonoBehaviour
{
    public static HungryTiger tiger;
    public bool tigerIsHungry;
    public GameObject boar,sound;
    public AudioSource clip;
    // Start is called before the first frame update
    void Start()
    { 
     tiger = this;
     boar.SetActive(false);
     tigerIsHungry =false;
     sound.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
     if (other.gameObject.tag == "Tiger") 
     {
      tigerIsHungry = true;
      boar.SetActive(true);
      clip.Play(); 
      
     }
     StartCoroutine(Stop());
    }
    IEnumerator Stop() 
    {
     yield return new WaitForSeconds(10);
     sound.SetActive(false);  
    
    }
}
