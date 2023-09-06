using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private const float SpawnInterval = 3f;

    private float _timeSinceLastSpawn = 0;

    [SerializeField]
    private GameObject _spawnPrefab;

    private void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;
        if (_timeSinceLastSpawn > SpawnInterval)
        {
            Instantiate(_spawnPrefab, transform.position, transform.rotation);
            _timeSinceLastSpawn = 0f;
        }
    }
}
