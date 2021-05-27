using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelctScene : MonoBehaviour
{
    public Button[] nivelBTN;

    void Start()
    {
        int nivel = PlayerPrefs.GetInt("nivel",6);

        for (int i = 0; i < nivelBTN.Length; i++)
        {
            if (i + 5 > nivel)
                nivelBTN[i].interactable = false;
            
        }
    }

    
}