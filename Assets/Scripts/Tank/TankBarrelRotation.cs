using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBarrelRotation : TankHaedRotation
{
    private float MouseY;
    private bool isAim = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (isAim == false)
            {
                isAim = true;
                mouseSensitivity = 50f;
            }
            else if (isAim == true)
            {
                isAim = false;
                mouseSensitivity = 400f;
            }
        }
        
        MouseY -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity * Time.deltaTime;
        MouseY = Mathf.Clamp(MouseY, -20f, 10f);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0, 0,  MouseY), 0.1f);

    }
}
