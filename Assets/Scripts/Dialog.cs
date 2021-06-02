using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textD;
    
    [TextArea (3,30)]
    public string[] parrafos;

    int index;

    public float velParrafo;

    public GameObject botonContinue;
    public GameObject botonQuitar;
    public GameObject panelDialogo;
    public GameObject botonLeer;
    public GameObject controles;
    public GameObject info;

    

    // Start is called before the first frame update
    private void Start()
    {
        botonQuitar.SetActive(false);
        botonLeer.SetActive(false);
        panelDialogo.SetActive(false);
        

    }

    // Update is called once per frame
    private void Update()
    {
        if (textD.text == parrafos[index])
        {
            botonContinue.SetActive(true);
        }
    }

    IEnumerator TextDialogo(){
        foreach (char letra in parrafos[index].ToCharArray())
        {
            textD.text += letra;
            yield return new WaitForSeconds(velParrafo);

        }
    }


    public void siguienteParrafo(){
        botonContinue.SetActive(false);
        if(index < parrafos.Length -1 ){
            index++;
            textD.text= "";
            StartCoroutine(TextDialogo());

        }
        else{
            textD.text= "";
            botonContinue.SetActive(false);
            botonQuitar.SetActive(true);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject.CompareTag("Player"))
        {
            botonLeer.SetActive(true);
        }
        else
        {
            botonLeer.SetActive(false);
        }
    }


    public void activarBotonLeer()
    {
        botonLeer.SetActive(false);
        controles.SetActive(false);
        panelDialogo.SetActive(true);
        StartCoroutine(TextDialogo());
    }

    public void botonCerrar()
    {
        panelDialogo.SetActive(false);
        botonLeer.SetActive(false);
        controles.SetActive(true);
        info.SetActive(false);
    }

}
