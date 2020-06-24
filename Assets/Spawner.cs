using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> Obstacles;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemySpawner", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void EnemySpawner()
    {
        int randNumber = Random.Range(0, 4);
        float randPositionX = Random.Range(-2.5f, 2.5f);
        

        Instantiate(Obstacles[randNumber], new Vector3(randPositionX,transform.position.y,transform.position.z), Quaternion.identity);
    }
}
