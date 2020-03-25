using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public GameObject ground3;
    private NavMeshAgent agent;
    public bool enterFlag;
    // Start is called before the first frame update
    void Start()
    {
        float posx = ground3.transform.position.x + Random.Range(-3, 3);
        float posz = ground3.transform.position.z + Random.Range(-30, 30);
        transform.position = new Vector3(posx, 1, posz);
        agent = GetComponent<NavMeshAgent>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            enterFlag = true;
        }
        else
        {
            enterFlag = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enterFlag)
        {
            agent.destination = player.transform.position;
        }
    }
}
