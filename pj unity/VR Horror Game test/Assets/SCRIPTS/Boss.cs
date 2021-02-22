using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private int health = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FirstLight")
        {

            StartCoroutine(GetDamage());
        }
    }
    
    IEnumerator GetDamage()
    {
        health -= 1;
        GetComponent<Renderer>().material.color = new Color(1, 0, 1, 1); //C#  }
        yield return new WaitForSeconds(0.2f);
        GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1); //C#  }
        if (health <= 0)
        {
            GetComponent<Renderer>().material.color = new Color(1, 1, 0, 1); //C#  }
        }
    }
}
