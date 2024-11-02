using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject enemy2;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        InvokeRepeating("CreateEnemy2", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 9f, 0), Quaternion.identity);
    }

    void CreateEnemy2()
    {
        // Randomly choose a negative positive or neither number
        int side = Random.Range(-1, 2);
        // Use the random number to determine if the entity will start on the left or right
        if (side == -1)
        {
            Instantiate(enemy2, new Vector3(-11, Random.Range(1f, 4f), 0), Quaternion.identity);
        }
        else if (side == 1)
        {
            Instantiate(enemy2, new Vector3(11, Random.Range(1f, 4f), 0), Quaternion.identity);
        }
    }
}
