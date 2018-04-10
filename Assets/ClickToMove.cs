using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour {

    [SerializeField]
    NavMeshAgent mNavMeshAgent;
    Vector3 destination;

    public GameObject[] gameObjects;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                mNavMeshAgent.SetDestination(hit.point);
                destination = hit.point;
            }
        }
    }

    public void SetAgent(NavMeshAgent navMeshAgent)
    {
        if (mNavMeshAgent != null)
        {
            var temp = navMeshAgent;
            temp.transform.position = mNavMeshAgent.transform.position;
            mNavMeshAgent = temp;
            mNavMeshAgent.SetDestination(destination);
        }
        else
        {
            mNavMeshAgent = navMeshAgent;
        }
    }

    


    /*NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
    }*/
}
