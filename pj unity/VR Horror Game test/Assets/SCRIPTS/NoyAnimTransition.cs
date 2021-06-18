using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoyAnimTransition : MonoBehaviour
{
    public Transform player;

    public float attackDistance;
    public float CalmDistance;

    public GameObject livre;
    
    public GameObject deathparticles;

    private Animator animnoy;

    private int health = 3;

    public AudioSource lit;
    public AudioSource attaque;
    public AudioSource souffre;
    public AudioSource vaincu;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        animnoy = GetComponent<Animator>();


        if (Menu.getNoy())
        {
            Destroy(this.gameObject);
        }

        lit.Play();
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
            
            StartCoroutine(GetDamage());
        }
    }

    IEnumerator GetDamage()
    {
        

        health -= 1;
        

        if (health <= 0)
        {
            Menu.NoyKilled();
            Debug.Log("Dead");
            animnoy.SetBool("IsDead", true);
            yield return new WaitForSeconds(1f);

            lit.Stop();
            vaincu.Play();

            Instantiate(deathparticles.gameObject);
            
           
        }
        else
        {
            Debug.Log("YES degat");
            animnoy.SetBool("IsHurt", true);

            lit.Stop();
            souffre.Play();

            yield return new WaitForSeconds(1f);
            animnoy.SetBool("IsHurt", false);
        }
    }
    
}
