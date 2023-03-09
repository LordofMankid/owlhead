using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{

    public Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Rigidbody.velocity = Vector3.forward;
        }
        if (Input.GetKeyDown("a"))
        {
            Rigidbody.velocity = Vector3.left;
        }
        if (Input.GetKeyDown("s"))
        {
            Rigidbody.velocity = Vector3.back;
        }
        if (Input.GetKeyDown("d"))
        {
            Rigidbody.velocity = Vector3.right;
        }
    }
}
