using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFunny : MonoBehaviour
{
    public GameObject Funny;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            StartCoroutine(Appear());
        }
    }

    private IEnumerator Appear()
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Alpha4));
        if(Funny.activeInHierarchy == true)
        {
            Funny.SetActive(false);
        }
        else
        {
            Funny.SetActive(true);
        }
    }
}
