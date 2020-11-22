using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class SpiritHandInteraction : MonoBehaviour
{
    public GameObject spiritHand;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Bouchon";
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bouchon")
        {
            DestroyObject(spiritHand.gameObject);
        }
    }
}
