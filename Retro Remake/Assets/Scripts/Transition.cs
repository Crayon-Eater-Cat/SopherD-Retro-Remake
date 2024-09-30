using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public UnityEvent OnHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OnHit.Invoke();
        }
    }
    public void LoadLevel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}