using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ��ų�������� �Ʒ� �������� Ư���ӵ��� �̵��Ѵ�.
// �Ӽ�: �Ʒ� ����, Ư���ӵ�
public class SkillItemMove : MonoBehaviour
{
    // �Ӽ�: �Ʒ� ����, Ư���ӵ�
    Vector3 dir = Vector3.down;
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        // ��ǥ: ��ų�������� �Ʒ� �������� Ư���ӵ��� �̵��Ѵ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
