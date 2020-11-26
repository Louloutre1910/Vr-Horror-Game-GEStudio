using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaundrySpirit : MonoBehaviour
{

    public GameObject key;
    public GameObject spirit;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Laundryspirit";
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laundryspirit")
        {
            DestroyObject(spirit.gameObject);
            
            Instantiate(key.gameObject);
        }
    }
}
