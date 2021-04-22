using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA_Control : MonoBehaviour
{
    public NavMeshAgent agent;
    
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }
}
