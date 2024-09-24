using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
public class Aim : MonoBehaviour
{
    private float Rdy;
    private float cD = 1;

    private Vector2 wrldPos;
    private Vector2 direc;
    private GameObject pewprojInst;
    [SerializeField] private GameObject pewpew;
    [SerializeField] private GameObject pewproj;
    [SerializeField] private Transform pewLiveHere;

    private void Update()
    {
        PewRotate();
        PewShoot();
        if (Rdy > 0)//wait time
        {
            Rdy -= Time.deltaTime;
        }
        if (cD <= 0)
        {
            cD = 0;
        }
        if (Rdy <= 0)
        {
            Rdy = 0;
        }
    }
    private void PewRotate()
    {
        wrldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direc = (wrldPos - (Vector2)pewpew.transform.position).normalized;
        pewpew.transform.right = direc;
    }
    private void PewShoot()
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (Rdy <= 0)
            {
                Rdy = cD;//Start CD
                pewprojInst = Instantiate(pewproj, pewLiveHere.position, pewpew.transform.rotation);
            }
        }
    }
}