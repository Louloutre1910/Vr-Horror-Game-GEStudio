using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoyAnimTransition : MonoBehaviour
{
    public Transform player;

    public float attackDistance;
    public float CalmDistance;
    public GameObject livre;
    public GameObject noy;
    public GameObject deathparticles;

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
        //Alert
        if (Vector3.Distance(player.position, transform.position) < attackDistance)
        {
            Debug.Log("Chara closed");
            animnoy.SetBool("IsAttacking", true);

          

        }

        if (Vector3.Distance(player.position, transform.position) > attackDistance)
        {
            Debug.Log("Chara far");
            animnoy.SetBool("IsAttacking", false);

        }


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Book")
        {
            Debug.Log("YES degat");
            animnoy.SetBool("IsHurt", true);

            StartCoroutine(GetDamage());
        }
    }

    IEnumerator GetDamage()
    {
        yield return new WaitForSeconds(0.7f);
        animnoy.SetBool("IsHurt", false);
        health -= 1;
        

        if (health <= 0)
        {
            Debug.Log("Dead");
            animnoy.SetBool("IsDead", true);

            Instantiate(deathparticles);

           
        }
    }
    
}
