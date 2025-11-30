using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject currentcheckpoint;
    private SavePoint savepoint;

    void Start()
    {
        this.savepoint = FindObjectOfType<SavePoint>();
    }
    void OnTriggerEnter(Collider other)
    {
        Rigidbody PlayerRb = other.GetComponent<Rigidbody>();
        if (other.CompareTag("Player"))
        {
            if (PlayerRb != null)
            {
                PlayerRb.velocity = Vector3.zero;
                PlayerRb.angularVelocity = Vector3.zero;
            }
                GameManager.Damage();//데미지
            // 소리남
            if (savepoint.SaveReach == true)
            {
                other.transform.position = new Vector3(1, 27, -3);
            }
            else
            {
                other.transform.position = new Vector3(5, 11, 0);// 플레이어 원위치
            }
        }
    }
}
