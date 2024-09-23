using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehav : MonoBehaviour
{
    public GameObject BreakTrump;
    public float destroyTime = 3f;

    [SerializeField] private LayerMask bulBrek;
    private float normalBulletSpeed = 15f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetDestroyTime();
        SetStraightVelocity();
    }

    private void SetStraightVelocity()
    {
        rb.velocity = transform.right * normalBulletSpeed;
    }
    private void SetDestroyTime()
    {
        Destroy(gameObject, destroyTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((bulBrek.value & (1 << collision.gameObject.layer)) > 0)
        {
            Destroy(gameObject);
        }
        //if (other.gameObject.CompareTag("Berk"))
        //{
        //    Debug.Log("Breakies");
        //    Destroy(gameObject, BreakTrump);dddd
        //}
    }
}
