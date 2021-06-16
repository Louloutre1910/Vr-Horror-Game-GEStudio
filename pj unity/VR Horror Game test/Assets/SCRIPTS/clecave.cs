using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clecave : MonoBehaviour
{
    public GameObject clécave;
    // Start is called before the first frame update
    void Start()
    {
        if(Menu.getBrick() && Menu.getBargh() && Menu.getNoy())
        {
            Instantiate(clécave.gameObject);
        }
    }

   
}
