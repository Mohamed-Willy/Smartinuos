using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSit : MonoBehaviour
{
    private bool touching;
    [SerializeField] private Camera Player, cam2;
    [SerializeField] private Canvas can;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "table")
        {
            touching = true;
            can.enabled = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "table")
        {
            touching = false;
            can.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && touching)
        {
           Player.enabled = false;
           cam2.enabled = true;
            touching = false;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Player.enabled = true;
            cam2.enabled = false;
        }
    }
}
