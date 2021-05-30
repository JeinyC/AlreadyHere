using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelctScene : MonoBehaviour
{
    public Button[] nivelBTN;
    public int nivelAcabado;

    void Start()
    {
        int nivel = PlayerPrefs.GetInt("nivel",6);

        for (int i = 0; i < nivelBTN.Length; i++)
        {
            
            if (i + 6 > nivel){
                if(PlayerPrefs.GetInt("NivelAcabado")==1){
                    nivelBTN[i].interactable = true;
                }else{
                nivelBTN[i].interactable = false;
                }
            }
            
        }
    }

    
}