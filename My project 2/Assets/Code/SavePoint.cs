using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    private Damage CheckManager;
    public bool SaveReach;

    void Start()
    {
        CheckManager = FindObjectOfType<Damage>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CheckManager.currentcheckpoint = GameObject.Find("savepoint");
            Destroy(gameObject);//큐브사라짐
            // 소리남
            SaveReach = true;
        }
    }
}
