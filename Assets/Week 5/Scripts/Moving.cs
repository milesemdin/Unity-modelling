using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector3.left;
        }
    }
}
