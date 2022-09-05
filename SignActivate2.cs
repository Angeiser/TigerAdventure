using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignActivate2 : MonoBehaviour
{
    public GameObject sign;
    // Start is called before the first frame update
    void Start()
    {
        sign.SetActive(false);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Sign1")
        {
            sign.SetActive(true);
        }
    }


}
