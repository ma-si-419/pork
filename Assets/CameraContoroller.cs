using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraContoroller : MonoBehaviour
{
    float CameraSpeed;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(PlayerController.playerspeed / 1175, 0, 0);
    }
}
