using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public int openingDirection;

    private int random;
    private bool spawned = false;

    //public GameObject roomHolder;
    private RoomHolder roomHolder;

    void Start()
    {

        roomHolder = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomHolder>();

        Invoke("SpawnMyRooms", 0.1f);
    }

    private void SpawnMyRooms()
    {

        if (!spawned)
        {

            if (openingDirection == 1)
            {
                //bot
                random = Random.Range(0, roomHolder.botRooms.Length);
                Instantiate(roomHolder.botRooms[random], transform.position,
                    roomHolder.botRooms[random].transform.rotation);

            }

            else if (openingDirection == 2)
            {
                //left
                random = Random.Range(0, roomHolder.leftRooms.Length);
                Instantiate(roomHolder.leftRooms[random], transform.position,
                    roomHolder.leftRooms[random].transform.rotation);
            }

            else if (openingDirection == 3)
            {
                //top
                random = Random.Range(0, roomHolder.topRooms.Length);
                Instantiate(roomHolder.topRooms[random], transform.position,
                    roomHolder.topRooms[random].transform.rotation);
            }

            else if (openingDirection == 4)
            {
                // right
                random = Random.Range(0, roomHolder.rightRooms.Length);
                Instantiate(roomHolder.rightRooms[random], transform.position,
                    roomHolder.rightRooms[random].transform.rotation);
            }

            spawned = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("RoomSpawnPoint"))
        {
            if (other.GetComponent<GenerateLevel>().spawned == false && spawned == false)
            {
                Instantiate(roomHolder.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }

            spawned = true;

        }

    }
}
