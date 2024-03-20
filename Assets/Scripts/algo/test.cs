using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class test : MonoBehaviour
{
    /*
     * Rajouter des murs tout autour de votre monde 
     */
    [SerializeField] GameObject _groundPrefab;
    [SerializeField] GameObject _WallPrefab;
    [SerializeField] int _longueur, _largeur;
     int[,] _theWorld;
    int dice;

     void Start()
    {
        init();
        genererLab();
        afficherLab();

    }
    public void genererLab()
    {
        for(int i = 0; i < _longueur; i++)
        {
            for (int j = 0; j < _largeur; j++)
            {
                dice = Random.Range(0, 101);

                if (i == 0 || j == 0 || i == _longueur-1 || j == _largeur-1)
                {
                    _theWorld[i, j] = 0;
                }
                else if(dice <= 80)
                {
                    _theWorld[i, j] = 1;
                }
                else
                {
                    _theWorld[i, j] = 2;
                }
                
            }

        }
    }
    public void afficherLab()
    {
        for (int i = 0; i < _longueur; i++)
        {
            for (int j = 0; j < _largeur; j++)
            {
                //int y = Random.Range(-1, 2);
                float y = Mathf.PerlinNoise(i / 10f, j / 10f) * 4;
                Vector3 pos = new Vector3(i, y, j);

                if (_theWorld[i, j] == 0)
                {
                    Instantiate(_WallPrefab, pos, Quaternion.identity);
                }
                else if (_theWorld[i, j] == 1)
                {
                    
                    Instantiate(_groundPrefab, pos, Quaternion.identity);
                }
                else if (_theWorld[i, j] == 2)
                {
                    //trou
                }
            }

        }
    }
    public void init()
    {
        _theWorld = new int[_longueur, _largeur];
    }
}
