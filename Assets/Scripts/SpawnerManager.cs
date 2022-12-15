using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// to manage randomly asteroid generation and falling
public class SpawnerManager : MonoBehaviour
{
    [SerializeField]
    private List<Spawner> _spawnPoints = new();
    [SerializeField]
    private float _spawnTime = 1f;

    private float _totalPoint;
    private float _currentTime;

    // Start is called before the first frame update
    void Start()
    {
        _totalPoint = _spawnPoints.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if(_currentTime <= 0)
        {
            int randomIndex = (int)Random.Range(0, _totalPoint - 1);
            _spawnPoints[randomIndex].Spawn();
            _currentTime = _spawnTime;
        }
        else
        {
            _currentTime -= Time.deltaTime;
        }
    }
}
