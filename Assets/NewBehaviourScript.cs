using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f; // �̵� �ӵ� ������ ���� ����

    void Update()
    {
        // Ű �Է¿� ���� �̵� ������ ����
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���⿡ ���� �̵� ���͸� ����
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // ���� ��ġ�� �̵� ���͸� ����
        transform.Translate(movement, Space.Self);
    }
}

