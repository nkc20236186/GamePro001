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
        //�t���[�����Ƃɓ����ŗ���������
        transform.Translate(-0.2f, 0, 0);

        //��ʊO�ɏo����I�u�W�F�N�g��j������
        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }

        //�����蔻��
        Vector2 p1 = transform.position;//�G�̒��S���W
        Vector2 p2 = this.eroonna.transform.position;//�v���C��̒��S���W
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.6f;//�G�̔��a
        float r2 = 0.8f;//�v���C���̔��a

        if (d < r1 + r2)
        {
            //�ēX�N���v�g�Ƀv���C���ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            //�Փ˂����ꍇ�͓G������
            Destroy(gameObject);
        }
    }
}
