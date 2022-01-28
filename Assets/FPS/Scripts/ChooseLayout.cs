using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLayout : MonoBehaviour
{

    public GameObject[] layouts;
    private int random;

    void Start()
    {
        random = Random.Range(0, layouts.Length);
        Instantiate(layouts[random], transform.position, Quaternion.identity);

        Destroy(gameObject);

    }


}
