using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ����(�Ѿ�) ���� ���ư���.
// ������ �ʿ��ϴ�.
// �ӵ��� �ʿ��ϴ�.

// ��ǥ: ���� �� ��ü�� �÷��̾����� ������ Ȯ�� ��, �߻� ������ ���Ѵ�.

public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.up;

    // ��ǥ: ����(�Ѿ�) ���� ���ư���.
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    //private void OnCollisionEnter(Collision otherObject)
    //{
    //    // ���� �ı��Ѵ�.
    //    Destroy(gameObject);

    //    // �ε��� ��븦 �ı��Ѵ�.
    //    Destroy(otherObject.gameObject);
    //}
}
