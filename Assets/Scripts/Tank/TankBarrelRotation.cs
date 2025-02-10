using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBarrelRotation : TankHaedRotation
{
    private float MouseY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseY -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity * Time.deltaTime;
        MouseY = Mathf.Clamp(MouseY, -20f, 10f);
        transform.localRotation = Quaternion.Euler(0, 0, MouseY);

    }
}
