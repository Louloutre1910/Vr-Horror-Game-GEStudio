using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickAnimation : MonoBehaviour
{
    public Transform player;

    public float attackDistance;
    public float CalmDistance;
    private bool isAttacking;
    private Animator animbrick;

    public GameObject Coin1;
    public GameObject Coin2;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        animbrick = GetComponent<Animator>();
        

        if (Menu.getBrick())
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        //Alert
        if (Vector3.Distance(player.position, transform.position) < attackDistance)
        {
            Debug.Log("Chara closed");
            animbrick.SetBool("IsAttacking", true);
            isAttacking = true;

            
        }

        if (Vector3.Distance(player.position, transform.position) > attackDistance)
        {
            Debug.Log("Chara far");
            animbrick.SetBool("IsAttacking", false);
            animbrick.SetBool("IsCatching", false);
            isAttacking = false;
        }

        if (isAttacking)
        {
            if (Vector3.Distance(Coin1.transform.position, transform.position) < attackDistance)
                {

                    animbrick.SetBool("IsAttacking", false);
                    animbrick.SetBool("IsCatching", true);
                    isAttacking = false;

                }
            
            if (Vector3.Distance(Coin2.transform.position, transform.position) < attackDistance)
                {

                    animbrick.SetBool("IsAttacking", false);
                    animbrick.SetBool("IsCatching", true);
                    isAttacking = false;

                }

            


        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin1")
        {
            Debug.Log("attrape");

            Coin1.SetActive(false);

            animbrick.SetBool("IsHiding", true);

            StartCoroutine(GetDawin());
        }
        if (other.gameObject.tag == "Coin2")
        {
            Debug.Log("attrape");

            Coin2.SetActive(false);

            animbrick.SetBool("IsHiding", true);

            StartCoroutine(GetDawin());
        }
    }

    IEnumerator GetDawin()
    {
        Menu.BrickKilled();
        Debug.Log("win");
        yield return new WaitForSeconds(0.1f);
       
        

    }
}
