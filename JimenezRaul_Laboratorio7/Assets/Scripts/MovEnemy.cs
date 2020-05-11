using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovEnemy : MonoBehaviour
{
    //variables
    public GameObject wp;
    public List<GameObject> wpList;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        wpList = new List<GameObject>();
        foreach(Transform child in wp.transform)
        {
            wpList.Add(child.gameObject);
        }
        agent.SetDestination(wpList[Random.Range(0, wpList.Count - 1)].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance < 0.2f)
        {
            if (wp)
            {
                agent.SetDestination(wpList[Random.Range(0, wpList.Count - 1)].transform.position);
            }
            
        }
    }
}
