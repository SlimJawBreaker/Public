using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(transform.position + cam.forward);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
