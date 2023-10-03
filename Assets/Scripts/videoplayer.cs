using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoplayer : MonoBehaviour
{
    [SerializeField] private VideoPlayer v;
    // Start is called before the first frame update
    void Start()
    {
        v.enabled = true;
        v.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
