using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            ChangeMainScene();
        }
    }
    public void ChangeMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
