using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControlle : MonoBehaviour
{
    int SpeedCount;
    //左右のボタンを押すことでスピードの調節を行えるようにする
    // Start is called before the first frame update
    void Start()
    {
        SpeedCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(SpeedCount > 0)
        {
            if((Input.GetKey("left")));
        }
        switch(SpeedCount)
        {
            case 1:
                {

                }
        }
    }
}
