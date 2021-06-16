using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public static int key = 0;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public static void BossKilled()
    {
        key += 1;
        Debug.Log(key);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public int getKey() { return key; }
}
