using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardMove : MonoBehaviour
{
    public static LizardMove lizard;
    public float movementSpeed = 20f, rotationSpeed = 100f;
    private bool isRotatingLeft = false, isRotatingRight = false, isWalking = false, isWandering;
    Animator animator;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        lizard = this;
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
        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
            animator.SetBool("isRunning", false);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);

        }
        if (isWalking)
        {
            rb.AddForce(transform.forward * movementSpeed);
            animator.SetBool("isRunnig", true);
        }
        if (isWalking == false)
        {
            animator.SetBool("isRunning", false);
        }

    }
    IEnumerator Wander()
    {
        int rotationTime = Random.Range(1, 3);
        int rotationWait = Random.Range(1, 3);
        int rotationDirection = Random.Range(1, 3);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 3);
        isWandering = true;
        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotationWait);
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
