using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiBasicscript : MonoBehaviour
{
    public Transform player;

    public float speed;
    public float alertDistance;
    public float simpleDistance;
    public float attackDistance;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Alert
        if(Vector3.Distance(player.position, transform.position) < alertDistance && 
           Vector3.Distance(player.position, transform.position) > attackDistance)
        {
            anim.SetBool("isAlert", true);
            anim.SetBool("isIdle", false);
        }


        //Attack
        else if(Vector3.Distance(player.position, transform.position) <= attackDistance)
        {
            anim.SetBool("isAttack", true);
            anim.SetBool("isAlert", false);
            anim.SetBool("isIdle", false);
        }
        

        //Idle
        else if(anim.GetBool("isIdle") == false)
        {
            anim.SetBool("isAttack", false);
            anim.SetBool("isAlert", false);
            anim.SetBool("isIdle", true);
        }
    }
}
