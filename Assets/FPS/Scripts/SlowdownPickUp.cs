using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Gameplay;
using UnityEngine;

public class SlowdownPickUp : MonoBehaviour
{

    TimeManager timeManager;
    float bobbingFrequency = 0.5f;
    float bobbingIntensity = 0.5f;

    void Start()
    {

        timeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();

    }

    private void FixedUpdate()
    {

        transform.Rotate(0 , 0.5f , 0);
        //transform.position = Vector3.up * Mathf.Cos(Time.time * bobbingFrequency) * bobbingIntensity;

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            timeManager.SlowdownTime();

            Destroy(gameObject);
        }

    }



}
