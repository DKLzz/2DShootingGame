using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ����� �Է�(Space)�� �޾� �Ѿ��� ����� �ʹ�.
// ����1: �Է��� �ް� �ʹ�.
// ����2: �Ѿ��� ����� �ʹ�.

// ��ǥ2: �������� �Ծ��ٸ�, ��ų ������ �ö󰣴�.
// �Ӽ�: ��ų����
public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunPos;
    public int skillLevel = 0;

    // Update is called once per frame
    void Update()
    {
        // ����1: �Է��� �ް� �ʹ�.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ExcuteSkill(skillLevel);
        }
    }

    private void ExcuteSkill(int _skillLevel)
    {
        switch(_skillLevel)
        {
            case 0:
                ExcuteSkill0();
                break;
            case 1:
                ExcuteSkill1();
                break;
            case 2:
                ExcuteSkill2();
                break;
        }

        // �Ѱ��� �Ѿ��� �߻�ȴ�.
        void ExcuteSkill0()
        {
            // ����2: �Ѿ��� ����� �ʹ�.
            GameObject bulletGO = Instantiate(bullet);

            // ����3: �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� �����ְ� �ʹ�.
            bulletGO.transform.position = gunPos.transform.position;
        }

        // �ΰ��� �Ѿ��� �߻�ȴ�.
        void ExcuteSkill1()
        {
            // ����2: �Ѿ��� ����� �ʹ�.
            GameObject bulletGO = Instantiate(bullet);
            GameObject bulletGO1 = Instantiate(bullet);

            // ����3: �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� �����ְ� �ʹ�.
            bulletGO.transform.position = gunPos.transform.position + new Vector3(-0.3f , 0, 0);
            bulletGO1.transform.position = gunPos.transform.position + new Vector3(0.3f, 0, 0);
        }

        // ������ �Ѿ��� �߻�ȴ�.
        // 1, 2, 3 �Ѿ� �� 1, 3 �Ѿ��� ���� Z������ -30��, 30�� ȸ�� �� �߻�ȴ�.
        void ExcuteSkill2()
        {
            // ����2: �Ѿ��� ����� �ʹ�.
            GameObject bulletGO = Instantiate(bullet);

            // ����3: �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� �����ְ� �ʹ�.
            bulletGO.transform.position = gunPos.transform.position;

            // ����2: �Ѿ��� ����� �ʹ�.
            GameObject bulletGO2 = Instantiate(bullet);
            GameObject bulletGO3 = Instantiate(bullet);

            // ����3: �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� �����ְ� �ʹ�.
            bulletGO2.transform.position = gunPos.transform.position + new Vector3(-0.3f, 0, 0);
            bulletGO2.transform.rotation = Quaternion.Euler(0, 0, 30);
            bulletGO2.GetComponent<Bullet>().dir = bulletGO2.transform.up;


            bulletGO3.transform.position = gunPos.transform.position + new Vector3(0.3f, 0, 0);
            bulletGO3.transform.rotation = Quaternion.Euler(0, 0, -30);
            bulletGO3.GetComponent<Bullet>().dir = bulletGO3.transform.up;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            skillLevel++;
        }
    }
}
