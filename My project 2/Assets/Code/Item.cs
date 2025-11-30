using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    AudioClip item;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.GetItem();// 점수 얻음
            if (item != null)
            {
                AudioSource.PlayClipAtPoint(item, transform.position);
            }
            Destroy(gameObject);// 아이템 사라짐
        }
    }
}
