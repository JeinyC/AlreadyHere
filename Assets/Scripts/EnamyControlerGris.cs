using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnamyControlerGris : MonoBehaviour
{
    public float speed = 1f;
    public float maxSpeed = 1f;
    private new Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.right * speed);
        float limitedSpeed = Mathf.Clamp(rigidbody2D.velocity.x, -maxSpeed, maxSpeed);
        rigidbody2D.velocity = new Vector2(limitedSpeed, rigidbody2D.velocity.y);

        if (rigidbody2D.velocity.x > -0.01 && rigidbody2D.velocity.x < 0.01)
        {
            speed = -speed;
            rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
        }

        if (speed > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (speed < -0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Caja")
        {
            float yoffset = 1.4f;
            if (transform.position.y + yoffset < collision.transform.position.y)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("DeadMenu");
        }
    }
}
