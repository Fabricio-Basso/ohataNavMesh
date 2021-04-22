using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    
    void Start()
    {
        //Encontrando todos os GO com essa tag "ai"
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    void Update()
    {
        //Pega a posição do mouse e seta como o destino
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                {
                    a.GetComponent<IA_Control>().agent.SetDestination(hit.point);
                }
            }
        }
    }
}
