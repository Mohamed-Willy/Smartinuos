using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowardsMovemeny : MonoBehaviour
{
    [SerializeField] private GameObject cam, Earth;
    // Update is called once per frame
    void Update()
    {
        cam.transform.position = Vector3.Lerp(cam.transform.position, Earth.transform.position + new Vector3(60,20,15), Time.deltaTime * 0.2f);
    }
}
