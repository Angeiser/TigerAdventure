using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignActivate3 : MonoBehaviour
{

    public AudioSource clip;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Sign2")
        {
         clip.Play();
        }
    }
}
