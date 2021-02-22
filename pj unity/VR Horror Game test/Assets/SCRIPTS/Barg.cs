using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barg : MonoBehaviour
{

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Spa")
        {
            GetComponent<Renderer>().material.color = new Color(1, 1, 0, 1);
        }
        else
        {
            if (other.gameObject.tag == "Book")
            {
                StartCoroutine(DeathScene());
            }
        }
        IEnumerator DeathScene()
        {
            Instantiate(gameOver.gameObject);
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Room1");
        }
    }
}