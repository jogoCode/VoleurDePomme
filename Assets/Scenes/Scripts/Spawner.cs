using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject m_objectToSpawn;
    [SerializeField] float m_spawnRange;

    [SerializeField] int m_countToSpawn;
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    { 
        for (int i = 0; i < m_countToSpawn; i++)
        {
            float randX = Random.Range(5, m_spawnRange);
            float randZ = Random.Range(5, m_spawnRange);
            var pomme = Instantiate(m_objectToSpawn,new Vector3(transform.position.x+randX, transform.position.y +5, transform.position.z + randZ), transform.rotation);
        }
    }
}
