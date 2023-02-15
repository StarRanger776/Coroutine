using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CapsuleMove : MonoBehaviour
{
    public NavMeshAgent navAgent;

    public GameObject target1;
    public GameObject target2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(ChangeDestination(target1));
            Debug.Log("pressed 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartCoroutine(ChangeDestination(target2));
        }
    }

    IEnumerator ChangeDestination(GameObject target)
    {
        Debug.Log("coroutine");
        yield return new WaitForSeconds(3);

        navAgent.SetDestination(target.transform.position);

        yield return null;
    }
}
