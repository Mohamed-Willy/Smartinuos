using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerUi : MonoBehaviour
{
    [SerializeField] private Canvas c1;
    [SerializeField] private Canvas rc1;
    [SerializeField] private Canvas c2;
    [SerializeField] private Canvas c3;
    [SerializeField] private Canvas c4;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "b1") {
            c1.enabled = true;
        }
        else if(collision.gameObject.tag == "b2")
        {
            rc1.enabled = true;
        }
        else if(collision.gameObject.tag == "b3")
        {
            c2.enabled = true;
        }
        else if(collision.gameObject.tag == "b4")
        {
            c3.enabled = true;
        }
        else if(collision.gameObject.tag == "b5")
        {
            c4.enabled = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "b1")
        {
            c1.enabled = false;
        }
        else if (collision.gameObject.tag == "b2")
        {
            rc1.enabled = false;
        }
        else if (collision.gameObject.tag == "b3")
        {
            c2.enabled = false;
        }
        else if (collision.gameObject.tag == "b4")
        {
            c3.enabled = false;
        }
        else if (collision.gameObject.tag == "b5")
        {
            c4.enabled = false;
        }
    }
}
