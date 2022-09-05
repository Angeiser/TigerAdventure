using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
     animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     if (AnimalMove.animal.isWalking) 
     {
      animator.SetBool("isRunning", true); 
     }
     else 
     {
      animator.SetBool("isRunning", false);   
     }
     if (AnimalMove.animal.isEating) 
     {
      StopCoroutine(AnimalMove.animal.Wander());
      animator.SetBool("Eating", true);      
     }
    }
}
