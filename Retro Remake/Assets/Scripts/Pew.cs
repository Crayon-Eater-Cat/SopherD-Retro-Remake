using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew : MonoBehaviour
{
    private float Rdy;

    private float cD = 0.25f;

    public KeyCode pew;
    //private Rigidbody2D RB2d;
    // Start is called before the first frame update
    void Start()
    {
        //Test
    }

    // Update is called once per frame
    void Update()
    {
        if (Rdy > 0)//wait time
        {
            cD -= Time.deltaTime;
        }
        if (Input.GetKey(pew))//Key input trigger
        {
            if (Rdy <= 0)//Allowed to shoot?
            {
                Rdy = cD;//Start CD
                Debug.Log("Pew Pew");
            }
        }
        if (cD <= 0)
        {
            cD = 0;
        }
        
    }
}
