using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRL : MonoBehaviour
{
    float jumpVelocity = 20f;
    Rigidbody2D rigidbody2d;
    private float groundLevel = -39.47f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = this.transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currPos = this.transform.position;
        bool onGround = this.transform.position.y < groundLevel;

        if (Input.GetKeyDown("right") && onGround)
        {
            rigidbody2d.AddForce(new Vector2(jumpVelocity, jumpVelocity), ForceMode2D.Impulse);
        }

        if(Input.GetKeyDown("left") && onGround)
        {
            if (currPos.x > 30)
            {
                rigidbody2d.AddForce(new Vector2(-1 * jumpVelocity, jumpVelocity), ForceMode2D.Impulse);
            }
        }
    }
}
