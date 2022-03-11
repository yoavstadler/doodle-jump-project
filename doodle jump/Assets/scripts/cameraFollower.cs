using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour
{
    // הגדרת משתנים
    public Transform PlayerTransform;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.y - PlayerTransform.position.y; // הגדרת מרווח
    }

    // Update is called once per frame
    void Update()
    {
        float newYposition = PlayerTransform.position.y + offset;
        if (transform.position.y < newYposition)
            transform.position = new Vector3(transform.position.x, newYposition, transform.position.z); // שינוי מיקום המצלמה לפי מיקום השחקן
        
    }
}
