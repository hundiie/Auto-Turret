using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;

    private bool check;
    void Start()
    {
    }

    //private float _RANDOM = Random.Range(1.0f, 3.0f);
    private float Delta;
    void Update()
    {
        Delta += Time.deltaTime;
        if (Delta >= 0.5f&& check == true)
        {
            Delta = 0;
            //_RANDOM = Random.Range(1.0f, 3.0f);

            GameObject bullet = Instantiate(BulletPrefab, transform.position,transform.rotation);
            bullet.transform.LookAt(Player);
        }
        
        if(check == false)
        {
            gameObject.transform.Rotate(0, 0, 10);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            check = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            check = false;
        }
    }

}
