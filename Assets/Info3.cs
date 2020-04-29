using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info3 : MonoBehaviour
{
    public bool hasBeenHit;
    Color lightColor;
    GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        hasBeenHit = false;
        lightColor = new Color(200f, 200f, 200f);
        panel = GameObject.Find("YourAdInfo");
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasBeenHit)
        {
            return;
        }

        hasBeenHit = true;
        this.GetComponent<SpriteRenderer>().color = lightColor;
        panel.SetActive(true);
    }

    public void OkayButtonPress()
    {
        panel.SetActive(false);
    }
}
