using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FichaRojaMov : MonoBehaviour
{   public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 4)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position = transform.position + new Vector3(2f, 0, 0);
            }
        }

        if (transform.position.x > -4)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position = transform.position + new Vector3(-2f, 0, 0);
            }
        }



        if (transform.position.y < 5)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position = transform.position + new Vector3(0, 2f, 0);
            }
        }


        if (transform.position.y > -5)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position = transform.position + new Vector3(0, -2f, 0);
            }
        }
        



    }
}
