using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angry_enemyScript : MonoBehaviour
{
    bool movment;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (movment) // הגדרת תנועת האוייב לפי המיקום שלו בציר האיקס
        {
            transform.position = transform.position + new Vector3(1.5f * Time.deltaTime, 1.5f* Time.deltaTime, 0); // תנועה ימינה
            transform.rotation = Quaternion.Euler(0, 180, 0);
            if (transform.position.x > 3)
                movment = false;
        }
        else
        {
            transform.position = transform.position - new Vector3(1.5f * Time.deltaTime, 1.5f * Time.deltaTime, 0); // תנועה שמאלה
            transform.rotation = Quaternion.Euler(0, 0, 0);
            if (transform.position.x < -3)
                movment = true;
        }
    }
}
