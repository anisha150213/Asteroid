using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player can shoot 
public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_bullet,transform.position,transform.rotation);
        }
    }
}
