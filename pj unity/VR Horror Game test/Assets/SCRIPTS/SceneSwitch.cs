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
    
    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RoomKey")
        {
            SceneManager.LoadScene(1);
        }
        
        
    }

}
