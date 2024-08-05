using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadMasterScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Button Clicked");
    }
    public void LoadScene1()
    {
        SceneManager.LoadScene(3);
        Debug.Log("Button Clicked");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Button Clicked");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Button Clicked");
    }

}
