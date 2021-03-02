using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
    public float fuerzaSalto;
    private Rigidbody2D rigidbody2D;
    private Animator animator;


    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    //Animación para que cuando deje de saltar siga caminando
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            animator.SetBool("estaSaltando", true);
            rigidbody2D.AddForce(new Vector2(0, fuerzaSalto));
        }
    }

    //Función para que cuando detecte el suelo no lo atraviese
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Suelo") {
            animator.SetBool("estaSaltando", false);
        }
    }
}
