using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;

public class OneShotPickUp : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            Damageable.oneShot = true;

            Destroy(gameObject);

        }


    }


}
