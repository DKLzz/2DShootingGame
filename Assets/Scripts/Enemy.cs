using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: �Ʒ� �������� �̵��Ѵ�.

// ��ǥ2: �ٸ� �浹ü�� �ε������� ��, ��븦 �ı��Ѵ�.

// ��ǥ3: ���۽� 30%�� Ȯ���� �÷��̾ ���󰣴�.
// �ʿ�Ӽ�: 30%�� Ȯ��

// ��ǥ4: 10������ Ȯ���� �÷��̾ ���󰣴�.
// �ʿ�Ӽ�: �÷��̾��� ����

// ��ǥ5: ���� �÷��̾ ���� Ư�� �ð��� �ѹ��� ���� ���.
// �ʿ�Ӽ�: �Ѿ�, Ư�� �ð�

public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;

    // �ʿ�Ӽ�: �÷��̾��� ����
    Vector3 playerDir;

    private void Start()
    {
        // �ʿ�Ӽ�: 30%�� Ȯ��
        randValue = Random.Range(0, 10); // 0 ~ 9 ������ ���� ��
        player = GameObject.Find("Player");

        if (randValue < 5)
        {
            if (player != null)
            {
                dir = (player.transform.position - gameObject.transform.position).normalized;
                //dir.Normalize();
            }
        }
    }

    // ��ǥ: �Ʒ� �������� �̵��Ѵ�.
    void Update()
    {
        // ��ǥ4: 10������ Ȯ���� �÷��̾ ���󰣴�.
        if (randValue < 3)
        {
            if(player != null) 
            {
                playerDir = (player.transform.position - gameObject.transform.position).normalized;
                dir = playerDir;
            }
            
        }

        transform.position += dir * speed * Time.deltaTime;
    }

    // ��ǥ2: �ٸ� �浹ü�� �ε������� ��, ��븦 �ı��Ѵ�.
    // �浹 ���� ����
    private void OnCollisionEnter(Collision otherObject)
    {
        // ���� �ı��Ѵ�.
        Destroy(gameObject);

        // �ε��� ��븦 �ı��Ѵ�.
        Destroy(otherObject.gameObject);
    }

    // �浹 �� ����
    private void OnCollisionStay(Collision collision)
    {
    }

    // �浹 ����� ����
    private void OnCollisionExit(Collision collision)
    {  
    }
}
