using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeTheGameScene : MonoBehaviour
{
    [Header("Scene's name")]
    [SerializeField] private string targetScene;
    //Code that will make the player change from Scene
    //Like change from main menu to game, or from convenction to the Competition room

    public void changeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        changeScene();
    }
}
