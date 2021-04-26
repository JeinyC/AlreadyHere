using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1f;
    public float maxSpeed = 1f;
    private Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    private void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.right * speed);
        float limitedSpeed = Mathf.Clamp(rigidbody2D.velocity.x, -maxSpeed, maxSpeed);
        rigidbody2D.velocity = new Vector2(limitedSpeed, rigidbody2D.velocity.y);

        if(rigidbody2D.velocity.x > -0.01 && rigidbody2D.velocity.x < 0.01)
        {
            speed = -speed;
            rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
        }

        if (speed > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }else if (speed < -0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

}
