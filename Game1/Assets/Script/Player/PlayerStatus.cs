using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int Player_HP;

    private void Update()
    {


    }
    public void Die()
    {
        gameObject.SetActive(false);
    }


}
