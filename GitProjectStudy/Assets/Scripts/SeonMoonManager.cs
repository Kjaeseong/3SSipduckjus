using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeonMoonManager : MonoBehaviour
{
    public GameObject SeonMoon;
    private GameObject[] SeonMoonPool = new GameObject[200];

    private int Count = 0;

    private void Start() 
    {
        for(int i = 0; i < 200; i++)
        {
            float randX = Random.Range(-4.5f, 4.5f);
            float randZ = Random.Range(-4.5f, 4.5f);

            SeonMoonPool[i] = Instantiate(SeonMoon);
            SeonMoonPool[i].name = "SeonMoon" + (i + 1) + "호";
            SeonMoonPool[i].transform.parent = gameObject.transform;
            SeonMoonPool[i].transform.position = new Vector3(randX, 0.7f, randZ);
            SeonMoonPool[i].SetActive(false);
        }
    }

    private void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.A) && Count < 199)
        {
            float randX = Random.Range(-4.5f, 4.5f);
            float randZ = Random.Range(-4.5f, 4.5f);
            SeonMoonPool[Count].transform.position = new Vector3(randX, 0.7f, randZ);
            SeonMoonPool[Count].SetActive(true);
            Count++;
        }

        if(Input.GetKey(KeyCode.D) && Count > 0)
        {
            SeonMoonPool[Count].SetActive(false);
            Count--;
        }       
    }
}
