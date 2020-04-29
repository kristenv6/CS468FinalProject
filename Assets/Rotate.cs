using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotateSpeed = 150f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currRotation = transform.rotation.eulerAngles;

        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(-1 * Vector3.forward * rotateSpeed * Time.deltaTime);
        }
    }
}
