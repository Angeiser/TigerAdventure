using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliciousMeat : MonoBehaviour
{
    public static DeliciousMeat dinner;
    public GameObject meat;
    public bool dinnerIsServer;
    // Start is called before the first frame update
    void Start()
    {
        dinner = this;
        dinnerIsServer = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Meat")
        {
         meat.SetActive(false); 
         dinnerIsServer = true;
      
        }
     
    }

}
