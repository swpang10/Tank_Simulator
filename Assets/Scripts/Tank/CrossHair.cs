using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CrossHair : Aim
{
    public RectTransform crosshairUI;
    public GameObject start;

    private void Start()
    {

    }
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(start.transform.position, start.transform.forward * 1000, Color.blue, 0.3f);
        if (Input.GetMouseButtonDown(1))
            if (cam2.enabled == false)
            {
                crosshairUI.gameObject.SetActive(true);
                if (Physics.Raycast(start.transform.position, start.transform.forward, out hit, 1000))
                {
                    Vector2 screenPos = Camera.main.WorldToScreenPoint(hit.point);
                    crosshairUI.position = screenPos;
                }
            }
            else
            {
                crosshairUI.gameObject.SetActive(false);
            }
    }
}
