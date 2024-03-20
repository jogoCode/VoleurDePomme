using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField] Vector3 m_offset;
    [SerializeField] GameObject m_target;
    [SerializeField] float m_moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,m_target.transform.position + m_offset,m_moveSpeed*Time.deltaTime);

  
 
    }
}
