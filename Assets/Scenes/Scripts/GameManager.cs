using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float m_score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_score = Time.time;
        //Debug.Log(m_score);
    }
}
