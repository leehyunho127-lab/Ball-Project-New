using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    [SerializeField]
    AudioClip save;

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
            GameManager.health = 3;
            CheckManager.currentcheckpoint = GameObject.Find("savepoint");
            Destroy(gameObject);//큐브사라짐
            if (save != null)// 소리남
            {
                AudioSource.PlayClipAtPoint(save, transform.position);
            }
            SaveReach = true;
        }
    }
}
