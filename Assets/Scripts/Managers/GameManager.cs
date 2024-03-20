using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int m_appleCount;

    public static Action AppleCountChanged;

    void Start()
    {
        Killable.OnDied += EndGame;
        Pickable.OnPickedUp += AddApple;
    }

    
    void Update()
    {
      
    }

    void AddApple()
    {
        m_appleCount += 1;
        AppleCountChanged();
    }

    void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public int GetAppleCount()
    {
        return m_appleCount;
    }
}
