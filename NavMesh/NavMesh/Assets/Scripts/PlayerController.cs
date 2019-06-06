using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            //Input.mousePosition
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                navMeshAgent.SetDestination(hit.point);
            }
        }
    }
}
