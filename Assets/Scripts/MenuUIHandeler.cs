using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class MenuUIHandeler : MonoBehaviour
{
    // Start is called before the first frame update
   

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();

    #endif
    }
        
    
}
