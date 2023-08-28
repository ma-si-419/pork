using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rigid2D;
    float jumpForce = 1020.0f;

    public static float playerspeed = 20;//プレイヤーの移動速度

    void Start()
    {
     this.rigid2D = GetComponent<Rigidbody2D>();   
    }


    //キーを押すと、プレイヤーが移動する
    void Update()
    {
        //常に行う処理
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }


    }

    void FixedUpdate()
    {
        //移動する

        this.transform.Translate(playerspeed / 50,0,0);
        
    }
}
