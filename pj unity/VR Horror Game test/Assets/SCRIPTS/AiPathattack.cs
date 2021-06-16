using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiPathattack : MonoBehaviour
{
    NavMeshAgent myAgent;
    Animator myAnimator;

    public Transform[] wayPoints;
    int nextWP;

    public GameObject player;
    public float attackRange;
    public float escapeRange;

    public bool isPatrolling;

    private int health = 6;

    private void Awake()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    private void Start()
    {
        PickNextWP();
        /*myAgent.updatePosition = false;*/
        isPatrolling = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (isPatrolling)
        {
            if (!myAgent.pathPending && myAgent.remainingDistance < .5f)
            {
                PickNextWP();
            }
        }

        float distanceToPlayer;
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if(distanceToPlayer <= attackRange)
        {
            isPatrolling = false;
            //myAgent.destination = player.transform.position;
            myAgent.ResetPath();
            
            myAnimator.SetBool("IsAttacking", true);
        }

        if(distanceToPlayer > attackRange && !isPatrolling)
        {
            isPatrolling = true;
            PickNextWP();

            
            myAnimator.SetBool("IsAttacking", false);
        }

        

        Vector3 worldDeltaPosition = myAgent.nextPosition - transform.position;

        if(worldDeltaPosition.magnitude > myAgent.radius)
        {
            myAgent.nextPosition = transform.position + 0.9f * worldDeltaPosition;
        }
    }


    /*private void OnAnimatorMove()
    {
        //Update pos based on animation mvmt on surface height plane
        Vector3 position = myAnimator.rootPosition;
        position.y = myAgent.nextPosition.y;
        transform.position = position;
    }*/


    void PickNextWP()
    {
        myAgent.destination = wayPoints[nextWP].position;
        nextWP++;

        if(nextWP == wayPoints.Length)
        {
            nextWP = 0;
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, escapeRange);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FirstLight")
        {
            myAnimator.SetBool("IsHurt", true);

            StartCoroutine(GetDamage());
        }
    }

    IEnumerator GetDamage()
    {
        health -= 1;

        Debug.Log("hurt");

        yield return new WaitForSeconds(0.3f);
        myAnimator.SetBool("IsHurt", false);

        if (health <= 0)
        {
            Debug.Log("IsDead");
            myAnimator.SetBool("IsDead", true);
           
        }
    }

}
