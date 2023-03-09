using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlController : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = 1;
    public bool allowKeyControls = true;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (allowKeyControls)
        {
            turn.x += Input.GetAxis("Mouse X") * sensitivity;
            turn.y += Input.GetAxis("Mouse Y") * sensitivity;
            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        }
    }
}
