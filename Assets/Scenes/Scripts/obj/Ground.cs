using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour,ICase
{
    [SerializeField] GameObject _grassPrefab;
    [SerializeField] GameObject _lavaPrefab;
    [SerializeField] GameObject _WallPrefab;
    [SerializeField] int _longueur, _largeur;
    int[,] _theWorld;
    int _dice , _wall = 0, _grass = 1, _throw = 2 ,_lava = 3 ;
    
    Vector3 posf;
    public Vector3 _pos()
    {
        posf = Vector3.zero;
        return posf;
    }
    

    void Start()
    {
        init();
        genererLab();
        afficherLab();

    }
    public void genererLab()
    {
        for (int i = 0; i < _longueur; i++)
        {
            for (int j = 0; j < _largeur; j++)
            {
                _dice = Random.Range(0, 101);

                if (i == 0 || j == 0 || i == _longueur - 1 || j == _largeur - 1)
                {
                    _theWorld[i, j] = _wall;
                }
                else if (_dice <= 60)
                {
                    _theWorld[i, j] = _grass;
                }
                else if (_dice > 70)
                {
                    _theWorld[i, j] = _throw;
                }
                else
                {
                    _theWorld[i, j] = _lava;
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
                //float y = Mathf.PerlinNoise(i / 10f, j / 10f) * 4;
                Vector3 pos = new Vector3(i, 2, j);

                if (_theWorld[i, j] == _wall)
                {
                    Vector3 pos1 = new Vector3(i, 3, j);
                    Instantiate(_WallPrefab, pos1, Quaternion.identity);
                }
                else if (_theWorld[i, j] == _grass)
                {

                    Instantiate(_grassPrefab, pos, Quaternion.identity);
                }
                else if (_theWorld[i, j] == _throw)
                {
                    //trou
                }
                else if (_theWorld[i, j] == _lava)
                {
                    Instantiate(_lavaPrefab, pos, Quaternion.identity);
                    
                }
            }

        }
    }
    public void init()
    {
        _theWorld = new int[_longueur, _largeur];
    }
}
