using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Transform[] _spawners;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(2);

        while (true)
        {
            for (int i = 0; i < _spawners.Length; i++)
            {
                Instantiate(_prefab, _spawners[i].position, Quaternion.identity);
                yield return wait;
            }
        }
    }
}
