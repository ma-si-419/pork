using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraContoroller : MonoBehaviour
{
    GameObject Player;
    Vector3 Playerpos;
    // Update is called once per frame
    void Update()
    {
        Player = GameObject.Find("Player");
        Playerpos = Player.transform.position;
        this.gameObject.transform.position = (new Vector3(Playerpos.x + 15, Playerpos.y, -30));
    }
}
