using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorY : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    void Update()
    {
        obj.transform.Rotate(0, 0.005f, 0);
    }
}
