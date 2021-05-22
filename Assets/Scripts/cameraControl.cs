using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour {

public Vector2 minCameraPos, maxCameraPos;
public GameObject camera;

void Start(){

}

void FixedUpdate(){
    float posX = camera.transform.position.x;
    float posY = camera.transform.position.y;

    transform.position = new Vector3(
        Mathf.Clamp(posX, minCameraPos.x, maxCameraPos.x),
        Mathf.Clamp(posY, minCameraPos.y, maxCameraPos.y),
        transform.position.z
        );
        }
}
