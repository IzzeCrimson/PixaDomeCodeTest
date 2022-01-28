using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    SpawnArray layout;
    public int spawnValue;
    int random;

    private void Start()
    {

        layout = GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnArray>();

        Invoke("SpawnObjects", 1f);

    }

    void SpawnObjects()
    {

        switch (spawnValue)
        {

            case 1:
                {

                    random = Random.Range(0, layout.enemies.Length);
                    Instantiate(layout.enemies[random], transform.position, Quaternion.identity);


                    break;
                }

            case 2:
                {

                    random = Random.Range(0, layout.pickUps.Length);
                    Instantiate(layout.pickUps[random], transform.position, Quaternion.identity);

                    break;
                }

            case 3:
                {

                    random = Random.Range(0, layout.obstacles.Length);
                    Instantiate(layout.obstacles[random], transform.position, Quaternion.identity);

                    break;
                }

            case 4:
                {

                    random = Random.Range(0, layout.obstaclesAndEnemies.Length);
                    Instantiate(layout.obstaclesAndEnemies[random], transform.position, Quaternion.identity);

                    break;
                }


            default:
                {
                    break;
                }
        }



    }

}
