using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class BulletBehav : MonoBehaviour
{
    public GameObject BreakTrump;
    public float destroyTime = 3f;

    [SerializeField] private LayerMask bulBrek;
    public float normalBulletSpeed = 15f;
    private Rigidbody2D rb;
    private Vector2 direction;

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
    }
}