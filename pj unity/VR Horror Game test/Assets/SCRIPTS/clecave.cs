using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clecave : MonoBehaviour
{
    public GameObject cl�cave;
    // Start is called before the first frame update
    void Start()
    {
        //if(Menu.getBrick() && Menu.getBargh() && Menu.getNoy())
        if (Menu.getBargh())
            {
            Debug.Log("l'instantiate pue la mort");
            Instantiate(cl�cave.gameObject);
        }
    }

   
}
