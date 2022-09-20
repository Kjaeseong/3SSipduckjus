using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class People : MonoBehaviour
{
    public GameObject _people;
    public GameObject[] Position_Target;

    private float elapsedTime = 0f;

    private void Start()
    {
        StartCoroutine(People_move());
    }
    private void Update()
    {

    }

    IEnumerator People_move()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime > 3f)
        {
            elapsedTime = 0f;
            _people.transform.position += Vector3.forward;
        }
        yield return null;
    }


}
