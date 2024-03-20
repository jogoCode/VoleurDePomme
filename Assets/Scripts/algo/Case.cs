using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{

    [SerializeField] GameObject[] m_Walls;
    [SerializeField] bool m_inBorder;

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
            if(m_inBorder == true) 
            {
                wall.SetActive(false);
            }
        
        }
    }

    public void SetAcitveBorder()
    {
        m_inBorder = true;
    }

    
}
