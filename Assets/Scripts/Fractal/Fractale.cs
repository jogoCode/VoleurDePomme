using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fractale : MonoBehaviour
{
    /***
     * On a 3 cubes (GameObject) : A, B, C
     * 1) On choisis comme point de départ A
     * 2) On choisis au hasard entre B et C on créer un nouveau cube à mi distance de A et du point choisi au hasard
     * 3) Ce nouveau cube est notre nouveau point de départ on répéte l'opération 10 000 fois;
     */

    [SerializeField] private GameObject[] cubes;

    [SerializeField] GameObject _cubePrefab;

    [SerializeField] GameObject _origin;

   
    void Start()
    {
        BuildFractalTri();
       
    }

    void Update()
    {

    }

    void BuildFractalTri() // Tri
    {
        for (int i = 0; i < 10000; i++)
        {
            int rand = Random.Range(0, cubes.Length);
            var midPoint = Vector3.Lerp(_origin.transform.position, cubes[rand].transform.position, 0.5f);
            _origin = Instantiate(_cubePrefab, midPoint, transform.rotation);
        }
    }

    /*IEnumerator BuildFractal()
      {
          for (int i = 0; i < 10000; i++)
          {
              int rand = Random.Range(0, cubes.Length);
              var midPoint = Vector3.Lerp(_origin.transform.position, cubes[rand].transform.position, 0.5f);
              yield return new WaitForSeconds(0.01f);
              _origin = Instantiate(_cubePrefab, midPoint, transform.rotation);
          }
      }*/
}
