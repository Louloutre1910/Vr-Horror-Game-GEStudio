using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightCave : MonoBehaviour
{

    public GameObject light1;
    private bool on = false;

  void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "PlayerRightHand" && !on)
        {
            light1.SetActive(true);
            on = true;
        }

      
    }


}
