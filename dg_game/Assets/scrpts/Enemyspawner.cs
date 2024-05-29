using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies; 
    private float[] arrPosX = {-2.2f, -1.1f, 0f, 1.1f, 2.2f};
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, enemies.Length);
        SpawnEnemy(arrPosX[0], index);
    }

    // Update is called once per frame
    void SpawnEnemy(float posX, int index)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
        Instantiate(enemies[index], spawnPos, Quaternion.identity );
    }
}
