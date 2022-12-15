using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asteroid entity script
public class Asteroid : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        //_player = FindObjectOfType<PlayerMovement>().gameObject;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * Time.deltaTime * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}

