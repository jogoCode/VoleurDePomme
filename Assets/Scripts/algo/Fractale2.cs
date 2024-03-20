using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractale2 : MonoBehaviour
{
    /* On crée une brique en x =  0 , y = 0;
 1) on répéte 10 000 fois 
 2) on lance un dés 100;
 - Si le dé fait 1: On applique à x, la fonction f1.
 - Si le dé fait entre 1 et 7: On applique la fonction f2
 - Si le dé fait entre 7 et 14: On applique la fonction f3
 - Sinon on applique la fonction f4

 */
    private float x, y;
    [SerializeField] GameObject _cubePrefab;
    void Start()
    {
       
        for (int i = 0; i < 50000; i++)
        {
            CreerBrique();
            ComputeNextPos();
        }
    }

    void CreerBrique()
    {
        Instantiate(_cubePrefab, new Vector3(x, y, 0),transform.rotation);
    }

    void ComputeNextPos()
    {
        int dice = Random.Range(1, 101);
        if(dice == 1)
        {
            fonction1();
        }
        else if(dice <= 7)
        {
            fonction2();
        }
        else if( dice <= 14)
        {
            fonction3();
        }
        else
        {
            fonction4();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void fonction1()
    {
        this.x = 0;
        this.y = this.y * 0.16f;
    }
    void fonction2()
    {
        this.x = this.x*0.2f-0.26f*y;
        this.y = this.y*0.23f+0.22f*y+1.6f;
    }
    void fonction3()
    {
        this.x = -this.x * 0.15f + 0.28f * y;
        this.y = this.x * 0.26f + 0.24f * y + 0.44f;
    }
    void fonction4()
    {
        this.x = 0.85f*x + 0.04f * y;
        this.y = -0.04f* x + 0.85f * y + 1.6f;
    }






}
