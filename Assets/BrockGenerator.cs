using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BrockGenerator : MonoBehaviour
{
    public GameObject BlockPrefab;//生成するゲームオブジェクト
    GameObject Block;
    float posX;//X座標
    int count = 1000;//ブロックの最大数 
    int span;
    int RandomNo;
    // Update is called once per frame
    void FixedUpdate()
    {
            span++;
        if (count > 0)
        {
            posX += 1.7f;
            Block = Instantiate(BlockPrefab) as GameObject;
            Block.transform.position = new Vector3(posX, 0, 0);
            count--;

        }
            RandomNo = Random.Range(0, 2);
            switch (RandomNo)
            {
                case 0:
                    Block.transform.position = new Vector3(posX, 1.5f, 0);
                    span = 0;
                    break;
                case 1:
                    Block.transform.position = new Vector3(posX, 3f, 0);
                    span = 0;
                    break;
                case 2:
                    Block.transform.position = new Vector3(posX, 4.5f, 0);
                    span = 0;
                    break;

            }
        
    }
}
