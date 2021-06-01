using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public static bool gameP;
    public static bool boolseguroP;

    public GameObject menuP, seguroP;

    private void Start()
    {
        menuP.SetActive(false);
        seguroP.SetActive(false);
    }


    public void SwitchPause()
    {
        if (gameP)
        {
            btnResume();
        }
        else
        {
            btnPause();
        }
    }
    


    void btnResume()
    {
        menuP.SetActive(false);
        Time.timeScale = 1;
        gameP = false;
    }

    void btnPause()
    {
        menuP.SetActive(true);
        Time.timeScale = 0;
        gameP = true;
    }


    public void mPrincipal(string name)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(name);
    }

    public void panel2()
    {
        seguroP.SetActive(true);
    }


    public void salirPno()
    {
        seguroP.SetActive(false);
    }

    public void salirPsi()
    {
        Application.Quit();
    }

}
