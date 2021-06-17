using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerdeath : MonoBehaviour
{

    public GameObject Lefthand;
    public GameObject Righthand;

    public GameObject gameOver;

    private int health = 3;

    public AudioSource ouch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NoyBook")
        {
            

            StartCoroutine(GetDamage());

        }

    }


    IEnumerator GetDamage()
    {
            Debug.Log("Player Hurt");

            health -= 1;
            Lefthand.GetComponent<Renderer>().material.color = new Color(1, 1, 0, 1);
            Righthand.GetComponent<Renderer>().material.color = new Color(1, 1, 0, 1);
            ouch.Play();




        if (health <= 0)
        {

            Debug.Log("Player Dead");
            Instantiate(gameOver.gameObject);
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Room1");
        }

    }

   


}
