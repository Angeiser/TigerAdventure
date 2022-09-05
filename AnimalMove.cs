using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
 public class AnimalMove : MonoBehaviour
{
    public static AnimalMove animal;
    public float movementSpeed = 20f, rotationSpeed = 100f;
    public bool isRotatingLeft = false,isRotatingRight=false,isWalking=false,isWandering,isHolwing,isEating;
    Animator animator;
    Rigidbody rb;
    public AudioSource clip,clip1;
    // Start is called before the first frame update
    void Start()
    {
     animal = this;
     animator = GetComponent<Animator>();
     rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {

     if (isWandering == false) 
     {
      StartCoroutine(Wander());   
     }
     if (isRotatingRight==true) 
     {
      transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
     
      
      clip1.Play();
     }
     if (isRotatingLeft == true)
     {
      transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);


      clip1.Play();
     }
     if (isWalking == true) 
     {
      rb.AddForce(transform.forward * movementSpeed);
      animator.SetBool("isRunning",true);
      clip1.Play();
     }
     if (isWalking == false) 
     {
      animator.SetBool("isRunning", false);
     }
     if (isHolwing == true) 
     {
      animator.SetBool("Howling", true);
      clip.Play();
      animator.SetBool("isRunning", false);
     }
     if (isHolwing == false) 
     {
      rb.AddForce(transform.forward * movementSpeed);
      animator.SetBool("Howling", false);
     }
    }
    public IEnumerator Wander() 
    {
     int rotationTime = Random.Range(1, 3);
     int rotationWait = Random.Range(1, 3);
     int rotationDirection = Random.Range(1, 3);
     int walkWait = Random.Range(1, 3);
     int walkTime = Random.Range(1, 3);
     int howWait = Random.Range(1, 3);
     int howTime = Random.Range(1, 3);
     isWandering = true;
     yield return new WaitForSeconds(walkWait);
     isWalking = true;
     yield return new WaitForSeconds(walkTime);
     isWalking = false;
     yield return new WaitForSeconds(rotationWait);
     isHolwing = true;
     yield return new WaitForSeconds(howTime);
     isHolwing = false;
     yield return new WaitForSeconds(howWait);
     if (rotationDirection == 1) 
     {
      isRotatingLeft = true;
      yield return new WaitForSeconds(rotationTime);
      isRotatingLeft = false;
     }
     if (rotationDirection == 2)
     {
      isRotatingRight = true;
      yield return new WaitForSeconds(rotationTime);
      isRotatingRight = false;
     }
     isWandering = false;
    }
}
