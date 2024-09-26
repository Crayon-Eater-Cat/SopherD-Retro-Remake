using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Bootn : MonoBehaviour
{
    public UnityEvent OnHit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PewProject")
        {
            OnHit.Invoke();
        }
    }
}
