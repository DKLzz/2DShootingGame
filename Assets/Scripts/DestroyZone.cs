using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: �� �Ǵ� �Ѿ��� �����Ǿ��� ��, �� ��ü�� �ı��ϰ� �ʹ�.
public class DestroyZone : MonoBehaviour
{
    // �浹 ����
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") {
            return;
        };

        Destroy(other.gameObject);
    }
}
