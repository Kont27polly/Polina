using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도 조절을 위한 변수
    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firePoint; // 총알이 발사될 위치

    public float bulletSpeed = 10f; // 총알 발사 속도

    void Update()
    {
        // 키 입력에 따라 이동 방향을 설정
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 방향에 따라 이동 벡터를 설정
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        // 현재 위치에 이동 벡터를 더함
        transform.Translate(movement, Space.Self);

        // 스페이스 키를 누르면 총알 발사
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 총알을 인스턴스화하고 발사 위치에 배치
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 총알에 속도 부여
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.velocity = firePoint.forward * bulletSpeed;
    }
}
