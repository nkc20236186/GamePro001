using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EroonnaController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        //����󂪉����ꂽ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(0, -1, 0);
        }
        //�E��󂪉����ꂽ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            transform.Translate(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            transform.Translate(1, 0, 0);
        }
    }
}
