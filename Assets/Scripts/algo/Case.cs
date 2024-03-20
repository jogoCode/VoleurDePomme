using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{

    [SerializeField] GameObject[] m_Walls;

    private void Start()
    {
        foreach (GameObject wall in m_Walls) {
            var rand = Random.Range(0, 3);
            if (rand == 0)
            {
                wall.SetActive(true);
            }
            else
            {
                wall.SetActive(false);
            }
        
        }
    }

    
}
