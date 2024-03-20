using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : Killable, IKillable
{
    [SerializeField] float m_moveSpeed;
    Vector3 m_vel;
    [SerializeField] float m_jumpFroce;

    [SerializeField] GameObject m_rayOrigin;
    Rigidbody m_rb;

    Vector3 m_mousePos;

    void Start()
    {
        if (!m_rb)
        {
            m_rb = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        m_vel.x = Input.GetAxisRaw("Horizontal");
        m_vel.z = Input.GetAxisRaw("Vertical");
        m_vel = m_vel.normalized * Time.deltaTime;
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            m_rb.AddForce(-Vector3.down * m_jumpFroce, ForceMode.Impulse);
        }
        m_rb.velocity = new Vector3(m_vel.x * m_moveSpeed, m_rb.velocity.y, m_vel.z * m_moveSpeed);
        if (transform.position.y < -3) Die();
    }

    private void OnTriggerEnter(Collider other)
    {
        Pickable pickable = other.GetComponent<Pickable>();
        if (pickable)
        {
            pickable.Pick();      
        }
    }

    bool IsGrounded()
    {
        if (Physics.Raycast(m_rayOrigin.transform.position, Vector3.down, 1.5f))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 6)
        {
            Die();
        }
    }

  
}
