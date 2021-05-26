using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
       
        gameObject.tag = "RoomKey";
        gameObject.tag = "BureauKey";
        gameObject.tag = "Room2Key";
        gameObject.tag = "Room3Key";

    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RoomKey")
        {
            SceneManager.LoadScene(1);
        }

        if (other.gameObject.tag == "BureauKey")
        {
            SceneManager.LoadScene(0);
        }

        if (other.gameObject.tag == "Room2Key")
        {
            SceneManager.LoadScene(2);
        }

        if (other.gameObject.tag == "Room3Key")
        {
            SceneManager.LoadScene(3);
        }



    }

}
