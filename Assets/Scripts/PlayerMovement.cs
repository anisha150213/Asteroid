using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Force Unity to serialize a private field.
    // it only serializes public fields. If you also want Unity to serialize your private fields you can add the SerializeField attribute to those fields.
    // can serialize  public non-static fields (of serializable types),
    // can serialize nonpublic non-static fields marked with the SerializeField attribute.
    // CANNOT serialize static fields.
    // CANNOT serialize properties.

    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * Time.deltaTime * _speed;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.up * Time.deltaTime * _speed;
            transform.eulerAngles = new Vector3(180f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.up * Time.deltaTime * _speed;
            transform.eulerAngles = new Vector3(0f,0f, 90f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.up * Time.deltaTime * _speed;
            transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }

    }
}
