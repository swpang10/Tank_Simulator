using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{

    float moveSpeed = -0.25f;
    float rotateSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            this.transform.Translate(new Vector3(moveSpeed, 0, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(-moveSpeed, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, rotateSpeed, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, -rotateSpeed, 0));
        }
    }
}
