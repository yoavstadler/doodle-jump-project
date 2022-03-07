using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform_script : MonoBehaviour
{
    [Range(5, 20)]
    public float jumpforce;
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
            transform.position = new Vector3(transform.position.x + 0.03f, transform.position.y, transform.position.z);
            if (transform.position.x > 3)
                movment = false;
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 0.03f, transform.position.y, transform.position.z);
            if (transform.position.x < -3)
                movment = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player_movment>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpforce;
                rb.velocity = newVelocity;
                Destroy(gameObject);
            }
           

        }
    }

    
}
