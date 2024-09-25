using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDie : MonoBehaviour
{
    //private float helf;
    public GameObject Self;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("PewProject"))
       {
           Destroy(gameObject);
           Debug.Log("Self die");
       }
    }
}