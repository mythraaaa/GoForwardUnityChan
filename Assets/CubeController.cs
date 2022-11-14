using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }
    // ���ʉ���炷�ׂ̏Փ˔���
    void OnCollisionEnter2D(Collision2D other)
    {

        if ((other.gameObject.tag == "GroundTag") || other.gameObject.tag == "CubeTag")
        {
            //���ʉ�
            GetComponent<AudioSource>().Play();
        }
        //Tag��\���i��FGroundTag, CubeTag�j
        Debug.Log("OnCollisionEnter2D: " + other.gameObject.tag);
    }
}
