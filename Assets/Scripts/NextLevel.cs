using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public int nextScene;
    public int actualScene;
    public bool NivelAcabado;
    
    // Start is called before the first frame update
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            if(actualScene==6){
                SceneManager.LoadScene("SelectLevelTierra");
            }
           else
            {
                PlayerPrefs.SetInt("NivelAcabado",1);
                PlayerPrefs.SetInt("nivel", nextScene);
                SceneManager.LoadScene(nextScene);
                
         
            }
        }
    }

    public void reset()
    {
        PlayerPrefs.DeleteAll();
    }




}
