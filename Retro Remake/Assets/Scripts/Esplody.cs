using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esplody : MonoBehaviour
{
    public GameObject explosionPrefab;
    public float esplodeTime = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Berk")
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(explosion, esplodeTime);
        }
    }
}