using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeedingTheTiger : MonoBehaviour
{
    public Animator animator;
    public AudioSource clip;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
     if (other.gameObject.tag == "Tiger") 
     {
      if (HungryTiger.tiger.tigerIsHungry == true && DeliciousMeat.dinner.dinnerIsServer == true) 
      {
       AnimalMove.animal.movementSpeed = 0f;
       AnimalMove.animal.rotationSpeed = 0f;
       animator.SetBool("isRunning", false);
       animator.SetBool("Howling", false);
       animator.SetBool("Eating", true);
       clip.Play();
       StartCoroutine(Finish());
      }   
     }
    }
    IEnumerator Finish() 
    {
     yield return new WaitForSeconds(15F);
        SceneManager.LoadScene("MainMenu");
    }
}
