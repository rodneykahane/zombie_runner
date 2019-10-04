using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;

    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (isProvoked)
        {
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
            navMeshAgent.SetDestination(target.position);
        }
    }

    private void EngageTarget()
    {
        if (something)
        {
            ChaseTarget();
        }

        if (somethingelse)
        {
            AttackTarget();  //test
        }
    }

    private void AttackTarget()
    {
        throw new NotImplementedException();
    }

    private void ChaseTarget()
    {
        throw new NotImplementedException();
    }

    void OnDrawGizmosSelected()
    {
        // Display the chaseRange radius when selected
        Gizmos.color = new Color(128, 0, 128, 0.75F);
        Gizmos.DrawWireSphere(transform.position, chaseRange);
        
    }
}
