using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superPlatform_Sound : MonoBehaviour
{
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player_movment>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0) // רק אם המהירות של השחקן היא שלילית
            {
                fire.GetComponent<AudioSource>().Play();
            }
        }
    }
}
