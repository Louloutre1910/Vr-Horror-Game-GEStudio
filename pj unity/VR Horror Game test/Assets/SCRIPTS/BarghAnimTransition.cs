using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarghAnimTransition : MonoBehaviour
{

    public GameObject gameOver;

    private Animator animbargh;

    // Start is called before the first frame update
    void Start()
    {
        animbargh = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Spa" )
        {
            Debug.Log("Win");
            animbargh.SetBool("IsWinning", true);
        }
        else
        {
            if (other.gameObject.tag == "FalseCard")
            {
                Debug.Log("Death");
                animbargh.SetBool("IsAttacking", true);
                StartCoroutine(DeathScene());
            }
        }
        IEnumerator DeathScene()
        {
            Instantiate(gameOver.gameObject);
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Room2");
        }
    }
}
