using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Is this working");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Title screen");
        Debug.Log("Is this working");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Is this working");
    }
}