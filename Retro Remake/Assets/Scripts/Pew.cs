using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew : MonoBehaviour
{
    public GameObject Bullet;
    private float Rdy;

    private float cD = 1;

    public KeyCode pew;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Rdy > 0)//wait time
        {
            Rdy -= Time.deltaTime;
        }
        if (Input.GetKeyDown(pew))//Key input trigger
        {
            if (Rdy <= 0)//Allowed to shoot
            {
                Rdy = cD;//Start CD
                Instantiate(Bullet, transform.position, Quaternion.identity);
                Debug.Log("Pew Pew");
            }
            else//Not allowed to shoot 
            {
                Debug.Log("No Pew");
            }
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
}
