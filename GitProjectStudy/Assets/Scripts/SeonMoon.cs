using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeonMoon : MonoBehaviour
{
    private int Pattern;

    private float moveSpeed;
    private float rotateSpeed;
    

    private void OnEnable() 
    {
        Debug.Log("앉아라");
        Pattern = Random.Range(1, 3);

        rotateSpeed = Random.Range(1, 10f);
        moveSpeed = Random.Range(0.01f, 0.05f);
    }

    void Update()
    {
        switch(Pattern)
        {
            case 1:
                RotatePattern();
                break;
            case 2:
                UpDownPattern();
                break;
        }
    }

    private void RotatePattern()
    {
        transform.Rotate(0f, rotateSpeed, 0f);
    }

    private void UpDownPattern()
    {
        if(transform.position.y > 0.7)
        {
            moveSpeed *= -1;
        }
        else if(transform.position.y < -0.7)
        {
            moveSpeed *= -1;
        }

        transform.Translate(0f, moveSpeed, 0f);
    } 
}
