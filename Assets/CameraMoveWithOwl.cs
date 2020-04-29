using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveWithOwl : MonoBehaviour
{
    GameObject owl;

    // Start is called before the first frame update
    void Start()
    {
        owl = GameObject.Find("Owl");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 owlPos = owl.transform.position;
        Vector3 cameraPos = this.transform.position;
        this.transform.position = new Vector3(owlPos.x, cameraPos.y, cameraPos.z);
    }
}
