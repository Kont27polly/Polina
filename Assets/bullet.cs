using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ� ������ ���� ����
    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePoint; // �Ѿ��� �߻�� ��ġ

    public float bulletSpeed = 10f; // �Ѿ� �߻� �ӵ�

    void Update()
    {
        // Ű �Է¿� ���� �̵� ������ ����
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���⿡ ���� �̵� ���͸� ����
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        // ���� ��ġ�� �̵� ���͸� ����
        transform.Translate(movement, Space.Self);

        // �����̽� Ű�� ������ �Ѿ� �߻�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // �Ѿ��� �ν��Ͻ�ȭ�ϰ� �߻� ��ġ�� ��ġ
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // �Ѿ˿� �ӵ� �ο�
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.velocity = firePoint.forward * bulletSpeed;
    }
}
