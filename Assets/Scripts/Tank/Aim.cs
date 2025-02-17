using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    public CinemachineVirtualCamera cam1;
    public CinemachineVirtualCamera cam2;

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        if (cam1.isActiveAndEnabled == true)
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
            
        }
        else if (cam2.isActiveAndEnabled == true)
        {
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
  
            }
    }

}
