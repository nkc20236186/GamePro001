using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KintamaController : MonoBehaviour
{
    public GameObject eroonna;
    void Start()
    {
        this.eroonna = GameObject.Find("Eroonna");
       
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに等速で落下させる
        transform.Translate(-0.2f, 0, 0);

        //画面外に出たらオブジェクトを破棄する
        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;//敵の中心座標
        Vector2 p2 = this.eroonna.transform.position;//プレイやの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;//敵の半径
        float r2 = 1.0f;//プレイヤの半径

        if (d < r1 + r2)
        {
            //衝突した場合は敵を消す
            Destroy(gameObject);
        }
    }
}
