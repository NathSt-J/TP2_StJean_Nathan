using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DeplacementMonstre : MonoBehaviour
{

    GameObject player;
    NavMeshAgent agent;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
