using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaseUpSeonMoon : MonoBehaviour
{
    private void OnEnable() 
    {
        transform.position = new Vector3(0f, -7f, 5f);
    }

    private void Update() 
    {
        PositionUp();
    }

    private void PositionUp()
    {
        if(transform.position.y <= 0)
        {
            transform.Translate(0f, 0.02f ,0f);
        }
    }
}
