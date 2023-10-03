using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCam : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform oriantation;
    private float x_rotation, y_rotation;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mousey = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        y_rotation +=mousex;
        x_rotation -=mousey;
        x_rotation = Mathf.Clamp(x_rotation, -90f, 90f);
        transform.rotation = Quaternion.Euler(x_rotation,y_rotation,0);
        oriantation.rotation = Quaternion.Euler(0, y_rotation,0);
    }
}
