using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asteroid Entity
public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _asteroid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(_asteroid, transform.position, Quaternion.identity);
    }
}
