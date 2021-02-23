using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*executa sin estar en el modo play*/
[ExecuteInEditMode]
public class ParallaxMundo1 : MonoBehaviour
{
    private float length;
    private float startPos;
    public float EfectoParallax;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x ;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temporal = (Camera.main.transform.position.x * (1 - EfectoParallax));
        float dist = (Camera.main.transform.position.x * EfectoParallax);

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        if (temporal > startPos + length)
        {
            startPos += length;
        }
        else if (temporal < startPos - length)
        {
            startPos -= length;
        }
        
    }
}
