using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normal_enemyScript : MonoBehaviour
{
    bool movment;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (movment)
        {
            transform.position = new Vector3(transform.position.x + 0.015f, transform.position.y, transform.position.z);
            if (transform.position.x > 3)
                movment = false;
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 0.015f, transform.position.y, transform.position.z);
            if (transform.position.x < -3)
                movment = true;
        }
    }
    
}
