using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;

    void Start()
    {
    }

    //private float _RANDOM = Random.Range(1.0f, 3.0f);
    private float Delta;
    void Update()
    {
        Delta += Time.deltaTime;
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Delta >= 0.5f)
            {
                Delta = 0;
                //_RANDOM = Random.Range(1.0f, 3.0f);

                GameObject bullet = Instantiate(BulletPrefab, transform);
                bullet.transform.LookAt(Player);
            }
        }
        
    }
}
