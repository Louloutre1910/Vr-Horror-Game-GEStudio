using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public AudioSource barriere;

    public static bool Brick = false;
    public static bool Bargh = false;
    public static bool Noy = false;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public static void BrickKilled()
    {
        Brick = true;
        Debug.Log("Brick killed : "+ Brick);
    }
    public static void BarghKilled()
    {
        Bargh = true;
        Debug.Log("Bargh killed : " + Bargh);

    }
    public static void NoyKilled()
    {
        Noy = true;
        Debug.Log("Noy killed : " + Noy);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        barriere.Play();
    }
    public static bool getBrick() { return Brick; }
    public static bool getBargh() { return Bargh; }
    public static bool getNoy() { return Noy; }
}
