using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPiedra : MonoBehaviour
{
    

    void OnCollision2D(Collision col)
    {
        if(col.gameObject.tag == "piedra"){
            Destroy(col.gameObject);
        } 
    }
}
