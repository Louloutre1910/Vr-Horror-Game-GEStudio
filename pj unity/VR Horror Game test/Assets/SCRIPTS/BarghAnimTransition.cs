using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarghAnimTransition : MonoBehaviour
{

    public GameObject gameOver;

    private Animator animbargh;

    public GameObject Spacard;
    public GameObject Falsecard1;
    public GameObject Falsecard2;
    public GameObject Falsecard3;

    public GameObject death;

   



    void Start()
    {
        animbargh = GetComponent<Animator>();
    }

    
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Spa"))
        {
            Spacard.SetActive(false);

            Debug.Log("Check");

            animbargh.SetBool("IsChecking", true);

            StartCoroutine(GetDawin());

            
        }

        if (other.gameObject.CompareTag("FalseCard"))
        {
            Debug.Log("Check");

            animbargh.SetBool("IsChecking", true);

            StartCoroutine(GetDamage());

            Falsecard1.SetActive(false);
            Falsecard2.SetActive(false);
            Falsecard3.SetActive(false);


        }

       
    }

    IEnumerator GetDawin()
    {
        
        Menu.BarghKilled();
        yield return new WaitForSeconds(2f);
        animbargh.SetBool("IsWinning", true);
        Instantiate(death.gameObject);
        
        
        
    }


    IEnumerator GetDamage()
    {
        
        yield return new WaitForSeconds(2f);
        animbargh.SetBool("IsAttacking", true);
        StartCoroutine(DeathScene());

    }

    IEnumerator DeathScene()
    {
        
        Instantiate(gameOver.gameObject);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Room2");
    }


    
}
