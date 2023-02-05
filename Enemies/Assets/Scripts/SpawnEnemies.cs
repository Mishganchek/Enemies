using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject enemy;


    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        for (int i = 0; i < 250 ; i++)
        {
            Instantiate(enemy, new Vector3(-8, 3, 0), Quaternion.identity);

            yield return new WaitForSeconds(2);

            Instantiate(enemy, new Vector3(5, 3, 0), Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }
}
