using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDiario : MonoBehaviour
{

    
    public static bool activeAlienPeludo;
    public static bool activeAlienGris;
    

    public GameObject menuP, seguroP;

    private void Start()
    {
        menuP.SetActive(true);
        seguroP.SetActive(false);
    }


    public void SwitchAlienPeludo()
    {
        btnAlienPeludo();
    }

    public void SwitchAlienGris(){
        
        btnAlienGris();

    }
    


    void btnAlienGris()
    {
        menuP.SetActive(false);
        seguroP.SetActive(true);

    }

    void btnAlienPeludo()
    {
        menuP.SetActive(true);
        seguroP.SetActive(false);
      
    }

}
