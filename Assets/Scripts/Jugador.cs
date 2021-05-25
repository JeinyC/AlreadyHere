using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float fuerzaSalto;
    private new Rigidbody2D rigidbody2D;
    private Animator animator;
    public float speed = 2f;
    public float maxSpeed = 5f;
    int saltosHechos;
    int saltosButton;
    int limiteSaltos = 2;
    private float posicionAnterior = 0;
    bool derecha = true;
    public float jumpSpeed = 5;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        //m_isGrounded=true;
        posicionAnterior = transform.position.x;
    }


    //Animación para que cuando deje de saltar siga caminando
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (saltosHechos < limiteSaltos)
            {
                rigidbody2D.AddForce(new Vector2(0, fuerzaSalto));
                animator.SetBool("estaSaltando", true);
                saltosHechos++;
            }


        }
    }


    //Función para que el personaje camine 
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


        //Rotar el personaje dependiendo de su posicion
        if (transform.position.x > posicionAnterior)
        {
            if (!derecha)
            {
                flip();
            }
            derecha = true;
        }
        else if (transform.position.x < posicionAnterior)
        {
            if (derecha)
            {
                flip();
            }
            derecha = false;
        }
        if (Time.frameCount % 5 == 0)
        {
            posicionAnterior = transform.position.x;
        }
    }


    //Función para que el personaje rote
    void flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


    //Función para que cuando detecte el suelo no lo atraviese
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            saltosHechos = 0;
            saltosButton = 0;
            animator.SetBool("estaSaltando", false);
        }
        if (collision.gameObject.tag == "CocheRojo")
        {
            saltosHechos = 0;
            saltosButton = 0;
            animator.SetBool("estaSaltando", false);
        }
    }

    public void jumpButton()
    {
        if (saltosButton < limiteSaltos)
            {
                rigidbody2D.velocity = Vector2.up * jumpSpeed;
                saltosButton++;
            }
    }
}
