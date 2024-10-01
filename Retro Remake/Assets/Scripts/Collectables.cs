using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collectables : MonoBehaviour
{
    public int Points;
    public TMPro.TMP_Text scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            Points++;
            Destroy(collision.gameObject);
        }
    }
    private void Update()
    {
        scoreText.SetText(Points.ToString());
    }
}