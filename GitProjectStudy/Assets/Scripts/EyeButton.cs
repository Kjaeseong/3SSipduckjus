using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeButton : MonoBehaviour
{
    public GameObject Eye;

    public void OpenEye()
    {
        Eye.SetActive(true);
    }
}
