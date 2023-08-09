using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// ��ǥ: ��ų�������� Ư���ð� ���� �����.
// �ʿ�Ӽ�: ��ų������, Ư���ð�, ����ð�
// �ܰ�1. �ð��� �帥��.
// �ܰ�2. ���� �ð��� Ư�� ���� �ð�(�ּҽð�, �ִ�ð�)�� ������
// �ܰ�3. ��ų�������� �����Ѵ�.
// �ܰ�4. ��ų ��ġ�� ��ų�Ŵ����� ��ġ�� �����Ѵ�.
// �ܰ�5. �ð��� �ٽ� �������ش�.
public class SkillManager : MonoBehaviour
{
    // �ʿ�Ӽ�: ��ų������, Ư���ð�, ����ð�
    public GameObject skillItem;
    float createTime;
    public float minCreateTime = 3;
    public float maxCreateTime = 10;
    float currentTime;

    private void Start()
    {
        createTime = UnityEngine.Random.Range(minCreateTime, maxCreateTime);
    }

    // Update is called once per frame
    void Update()
    {
        // ��ǥ: ��ų�������� Ư���ð� ���� �����.
        // �ܰ�1. �ð��� �帥��.
        currentTime += Time.deltaTime;

        // �ܰ�2. ���� �ð��� Ư���ð��� ������
        if(currentTime > createTime)
        {
            // �ܰ�3. ��ų�������� �����Ѵ�.
            GameObject skillItemGO = Instantiate(skillItem);

            // �ܰ�4. ��ų ��ġ�� ��ų�Ŵ����� ��ġ�� �����Ѵ�.
            skillItemGO.transform.position = transform.position;

            currentTime = 0;

            // �ܰ�5. �ð��� �ٽ� �������ش�.
            createTime = UnityEngine.Random.Range(minCreateTime, maxCreateTime);
        }
    }
}
