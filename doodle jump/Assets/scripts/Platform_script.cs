using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_script : MonoBehaviour
{
    // הגדרת משתנים
    [Range(5,20)]
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) // הגדרה של מקרה של השחקן נכנס לפלטפורמה
    {
        if (other.GetComponent<Player_movment>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0) // רק אם המהירות של השחקן היא שלילית
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpforce;
                rb.velocity = newVelocity;// הגדרת מהירות חדשה
                GetComponent<AudioSource>().Play();
            }

        }
    }
}
