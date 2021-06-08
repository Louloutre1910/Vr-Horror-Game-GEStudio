using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightCave : MonoBehaviour
{

    public GameObject light1;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerRightHand")
        {
            Debug.Log("light");
            Instantiate(light1);
        }
    }


}
