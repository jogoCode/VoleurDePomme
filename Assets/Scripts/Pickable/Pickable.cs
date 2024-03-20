using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

// Classe abstraitre attrapable impl�mante notre interface
public abstract class Pickable : MonoBehaviour, IPickable
{
    protected float m_poids;
    public abstract void Pick();

    public float Poids { get => m_poids; set => m_poids = value;}//Raccourcis pour les accesseurs

    public float GetPoids()
    {
        return m_poids;
    }

    public void SetPoids(float poids)
    {
        m_poids = poids;
    }
}