using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    AudioSource myAudio;
    public Vector3 inputVec; //입력방향
    public float movePower; //이동속도
    public float jumpPower; //점프힘
    public bool isGround; // 바닥 닿았는지 유무

    Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>(); //초기화
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxis("Horizontal");
        inputVec.z = Input.GetAxis("Vertical");
        bool isJump = Input.GetButtonDown("Jump");

        if (isGround && isJump) {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            myAudio.Play();
        }
    }

    void FixedUpdate()
    {
        if (isGround)
        {
            rigid.AddForce(inputVec * movePower);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        isGround = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }
}
