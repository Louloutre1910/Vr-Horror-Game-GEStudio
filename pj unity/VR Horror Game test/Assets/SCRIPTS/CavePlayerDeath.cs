using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CavePlayerDeath : MonoBehaviour
{


    public GameObject gameOver;

    private int health = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Osskwour")
        {


            StartCoroutine(GetDamage());

        }

    }


    IEnumerator GetDamage()
    {
        Debug.Log("Player Hurt");

        health -= 1;
      

        if (health <= 0)
        {

            Debug.Log("Player Dead");
            Instantiate(gameOver.gameObject);
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Cave");
        }

    }




}
