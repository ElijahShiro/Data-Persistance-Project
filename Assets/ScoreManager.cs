using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    public string playerName;
    // Update is called once per frame
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this; 
        DontDestroyOnLoad(gameObject);
    }

    public void ReadStringInput(string play)
    {
        playerName = play;
        Debug.Log(playerName);
    }
}
