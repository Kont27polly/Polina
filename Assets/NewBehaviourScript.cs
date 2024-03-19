using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f; // 이동 속도 조절을 위한 변수

    void Update()
    {
        // 키 입력에 따라 이동 방향을 설정
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 방향에 따라 이동 벡터를 설정
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // 현재 위치에 이동 벡터를 더함
        transform.Translate(movement, Space.Self);
    }
}

