using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float fuerzaSalto;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    public float speed = 2f;
    public float maxSpeed = 5f;
    int saltosHechos;
    int limiteSaltos=2;
    bool m_isGrounded;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        m_isGrounded=true;
        saltosHechos=0;
    }


    //Animación para que cuando deje de saltar siga caminando
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(saltosHechos<limiteSaltos){
                rigidbody2D.AddForce(new Vector2(0, fuerzaSalto));
                animator.SetBool("estaSaltando", true);
                saltosHechos++;
            }
            
            
        }
    }


    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rigidbody2D.AddForce(Vector2.right * speed * h);

        if (rigidbody2D.velocity.x > maxSpeed)
        {
            rigidbody2D.velocity = new Vector2(maxSpeed, rigidbody2D.velocity.y);
        }

        if (rigidbody2D.velocity.x < -maxSpeed)
        {
            rigidbody2D.velocity = new Vector2(-maxSpeed, rigidbody2D.velocity.y);
        }

    }


    //Función para que cuando detecte el suelo no lo atraviese
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            saltosHechos=0;
            animator.SetBool("estaSaltando", false);
        }
        if (collision.gameObject.tag == "CocheRojo")
        {
            saltosHechos=0;
            animator.SetBool("estaSaltando", false);
        }
    }
}
