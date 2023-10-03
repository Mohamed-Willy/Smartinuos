using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movelight : MonoBehaviour
{
    public GameObject cur, target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cur.transform.position = target.transform.position;
    }
}
