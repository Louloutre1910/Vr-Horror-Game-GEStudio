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

    // Start is called before the first frame update
    void Start()
    {
        animbargh = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Spa"))
        {
            Debug.Log("Check");

            animbargh.SetBool("IsChecking", true);

            StartCoroutine(GetDawin());

            Destroy(Spacard.gameObject);
        }

        if (other.gameObject.CompareTag("FalseCard"))
        {
            Debug.Log("Check");

            animbargh.SetBool("IsChecking", true);

            StartCoroutine(GetDamage());

            Destroy(Falsecard1.gameObject);
        }

       
    }

    IEnumerator GetDawin()
    {
        yield return new WaitForSeconds(3f);
        animbargh.SetBool("IsWinning", true);
        Destroy(Spacard.gameObject);

    }


    IEnumerator GetDamage()
    {
        Destroy(Falsecard1.gameObject);
        Destroy(Falsecard2.gameObject);
        Destroy(Falsecard3.gameObject);
        yield return new WaitForSeconds(2.5f);
        animbargh.SetBool("IsAttacking", true);
        StartCoroutine(DeathScene());

    }

    IEnumerator DeathScene()
    {
        Menu.BossKilled();
        Instantiate(gameOver.gameObject);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Room2");
    }


    
}
