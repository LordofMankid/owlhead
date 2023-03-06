using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMovement : MonoBehaviour
{
    public float speed = 10f;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
