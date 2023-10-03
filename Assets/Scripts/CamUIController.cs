using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamUIController : MonoBehaviour
{
    [SerializeField] private Camera cam1, cam2, cam3, cam4, cam5;
    [SerializeField] private Canvas c1, c2, c3, c4, c5;
    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
        c1.enabled = false;
        c2.enabled = false;
        c3.enabled = false;
        c4.enabled = false;
        c5.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cam2.enabled = true;
            cam1.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cam3.enabled = true;
            cam1.enabled = false;
            cam2.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            cam4.enabled = true;
            cam1.enabled = false;
            cam3.enabled = false;
            cam2.enabled = false;
            cam5.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            cam5.enabled = true;
            cam1.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam2.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            c1.enabled = false;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            if (flag)
            {
            flag = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            }
            else
            {
                flag = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
