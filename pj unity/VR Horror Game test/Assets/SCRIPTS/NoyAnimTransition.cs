using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoyAnimTransition : MonoBehaviour
{
    public Transform player;

    private Animator animnoy;

    private int health = 5;

    // Start is called before the first frame update
    void Start()
    {
        animnoy = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Book")
        {
            Debug.Log("YES degat");
            animnoy.Play("Scene 2");

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
            animnoy.Play("Scene 3");
        }
    }
    
}
