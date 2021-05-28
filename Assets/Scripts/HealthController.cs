using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthController : MonoBehaviour
{
    [SerializeField] Image uiSalud;

    [SerializeField] [Range(0, 1)] float uiSaludBar;

    public float restarHealth;


    // Start is called before the first frame update
    public void Start()
    {
        uiSaludBar = 1;
    }

    // Update is called once per frame
    public void Update()
    {
        float salud1 = PlayerPrefs.GetFloat("salud");
        restarHealth =  salud1;
        uiSalud.fillAmount = restarHealth;
        

    }
}
