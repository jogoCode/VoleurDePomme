using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*/
 -On veut pouvoir attraper une pomme
 -Attrapable si quoi ?: attraper;
 */

public class Pomme : Pickable 
{
    public override void Pick()
    {
        Debug.Log("J'attrape une pomme");
        OnPickedUp();
        Destroy(gameObject,0.1f);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
