using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    private AudioSource audio1;
    public AudioClip ring;

    private AudioSource audio2;
    public AudioClip call;
    
    void Start()
    {
       audio1 = GetComponent<AudioSource>();
        audio1.loop = true;
       audio2 = GetComponent<AudioSource>();
        
       
        Invoke("playRing", 5.0f);

        

    }

    void playRing()
    {
        audio1.clip = ring;
        audio1.Play();
      
    }

    void update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerHand")
        {
            audio1.Stop();
            audio1.loop = false;
            audio2.clip = call;
            audio2.Play();

            

        }
    }



}
