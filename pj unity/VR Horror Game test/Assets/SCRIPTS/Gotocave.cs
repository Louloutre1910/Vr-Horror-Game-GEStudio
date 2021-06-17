using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gotocave : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        
        gameObject.tag = "Cave";

    }

    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Cave")
        {
            SceneManager.LoadScene(7);
        }


    }

}
