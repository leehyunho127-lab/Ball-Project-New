using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Damage();//데미지
            // 소리남
            other.transform.position = Vector3.up;// 플레이어 원위치
        }
    }
}
