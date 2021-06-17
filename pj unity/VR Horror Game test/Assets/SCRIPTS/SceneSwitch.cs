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
        gameObject.tag = "Room2Key";
        gameObject.tag = "Room3Key";
        gameObject.tag = "Bureau2";
        gameObject.tag = "Bureaufin";
        

    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RoomKey")
        {
            SceneManager.LoadScene(2);
        }


        if (other.gameObject.tag == "Room2Key")
        {
            SceneManager.LoadScene(3);
        }

        if (other.gameObject.tag == "Room3Key")
        {
            SceneManager.LoadScene(4);
        }

        if (other.gameObject.tag == "Bureau2")
        {
            SceneManager.LoadScene(5);
        }
        if (other.gameObject.tag == "Bureaufin")
        {
            SceneManager.LoadScene(6);
        }

       


    }

}
