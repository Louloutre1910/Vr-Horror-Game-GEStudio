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

    // Start is called before the first frame update
    void Start()
    {
        animbrick = GetComponent<Animator>();
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
            isAttacking = false;
        }

        if (isAttacking)
        {
            if (Coin1 != null)
            {
                if (Vector3.Distance(Coin1.transform.position, transform.position) < attackDistance)
                {

                    animbrick.SetBool("IsAttacking", false);
                    animbrick.SetBool("IsCatching", true);
                    isAttacking = false;
                }
            }
            
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("attrape");
            Destroy(Coin1.gameObject);
            Destroy(Coin2.gameObject);


            animbrick.SetBool("IsHiding", true);

            StartCoroutine(GetDawin());
        }
    }

    IEnumerator GetDawin()
    {
        Menu.BrickKilled();
        Debug.Log("win");
        yield return new WaitForSeconds(0.1f);
        animbrick.SetBool("IsAttacking", true);
        

    }
}
