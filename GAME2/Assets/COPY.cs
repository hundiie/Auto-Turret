using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COPY : MonoBehaviour
{
    private GameObject Sphere;

    private void Start()
    {
        Sphere = GetComponent<GameObject>();
    }
    private void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(" 터치함");

        if (other.tag == "WALL")
        {
            Instantiate(Sphere, transform.position, transform.rotation);

            Debug.Log(" 벽 터치함");
        }
    }
}
