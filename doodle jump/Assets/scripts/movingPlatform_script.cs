using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform_script : MonoBehaviour
{ 
    // הגדרת משתנים
    [Range(5, 20)]
    public float jumpforce;
    bool movment;
    public GameObject Destroyer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movment) // הגדרת תנועת הפלטפורמה לפי המיקום שלה בציר האיקס
        {
            transform.position = transform.position + new Vector3(1.5f * Time.deltaTime, 0, 0); // תנועה ימינה
            if (transform.position.x > 3)
                movment = false;
        }
        else
        {
            transform.position = transform.position - new Vector3(1.5f * Time.deltaTime, 0, 0); // תנועה שמאלה
            if (transform.position.x < -3)
                movment = true;
        }
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
                rb.velocity = newVelocity; // הגדרת מהירות חדשה
                transform.position = new Vector3(Destroyer.transform.position.x, Destroyer.transform.position.y + 2, Destroyer.transform.position.z);
                GetComponent<AudioSource>().Play();
                Destroy(gameObject, 2);
            }
           

        }
    }

   

    
}
