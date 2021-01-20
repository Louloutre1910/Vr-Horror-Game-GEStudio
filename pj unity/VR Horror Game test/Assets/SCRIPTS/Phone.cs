using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{

    AudioSource phoneCall;

    // Start is called before the first frame update
    void Start()
    {
        phoneCall = GetComponent<AudioSource>();
        Invoke("playAudio", 10.0f);
       
    }

    void playAudio()
    {
        phoneCall.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
