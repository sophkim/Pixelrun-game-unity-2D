using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{
    Vector2 pos; //���� ��ġ
    float delta = 1.2f; //�¿� �̵� �ִ밪
    float speed = 0.5f; //�̵��ӵ�

    void Start()
    {
        //���� ��ġ ����
        pos = transform.position;
    }


    void Update()
    {
        Vector2 v = pos;
        v.x -= delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}