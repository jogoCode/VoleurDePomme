using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killable : MonoBehaviour, IKillable
{

    public static Action OnDied;
 
    void Start()
    {
        
    }

   
    public void Die()
    {
        OnDied();
    }
}
