using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    
    [SerializeField]
    private GameObject _enemyContainer;

    private bool _isSpawning = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Spawn enemy every 3 seconds
    IEnumerator SpawnRoutine()
    {
        // infinite loop
        // instantiate an enemy prefab
        // wait 3 seconds
        while (_isSpawning == true)
        {
            float posX = Random.Range(-8f, 8f);
            GameObject enemy = Instantiate(_enemyPrefab, new Vector3(posX, 7, 0), Quaternion.identity);
            enemy.transform.SetParent(_enemyContainer.transform);
            yield return new WaitForSeconds(3f);
        }
    }

    public void OnPlayerDeath()
    {
        _isSpawning = false;
    }
}
