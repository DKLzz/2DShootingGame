using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ����� �Է�(Space)�� �޾� �Ѿ��� ����� �ʹ�.
// ����1: �Է��� �ް� �ʹ�.
// ����2: �Ѿ��� ����� �ʹ�.
public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunPos;

    // Update is called once per frame
    void Update()
    {
        // ����1: �Է��� �ް� �ʹ�.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ����2: �Ѿ��� ����� �ʹ�.
            GameObject bulletGO = Instantiate(bullet);

            // ����3: �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� �����ְ� �ʹ�.
            bulletGO.transform.position = gunPos.transform.position;
        }
    }
}
