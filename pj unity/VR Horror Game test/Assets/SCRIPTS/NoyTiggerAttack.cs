using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoyTiggerAttack : MonoBehaviour
{

    private Animator animnoy;

    void Start()
    {
        animnoy = GetComponent<Animator>();
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerRightHand")
        {
            Debug.Log("YES attack");
            animnoy.Play("Scene 1");

            
        }
    }


   
}
