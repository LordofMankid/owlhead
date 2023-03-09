using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargettingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            print("Target Spotted");
            Destroy(collision.gameObject);
        }
    }
}

// && Input.GetKeyDown(KeyCode.Space)