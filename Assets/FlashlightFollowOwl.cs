using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightFollowOwl : MonoBehaviour
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
        this.transform.position = new Vector3(owlPos.x + 5, owlPos.y - 1, owlPos.z);
    }
}
