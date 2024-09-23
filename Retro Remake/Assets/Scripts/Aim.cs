using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Aim : MonoBehaviour
{
    private Vector2 wrldPos;
    private void Update()
    {
        PewRotate();
    }
    private void PewRotate()
    {
        wrldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
    }
}
