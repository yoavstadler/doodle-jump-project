using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCounterScript : MonoBehaviour
{
   
    public GameObject coins; // קריאה לגיים אובג'קט של המטבעות
    public GameObject Destroyer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.transform.rotation =  Quaternion.Euler (0, (gameObject.transform.rotation.y + 45)*Time.time, 0); // שינוי הסיבוב של המטבע כדי יצירה של אנימצייה
    }
    private void OnTriggerEnter(Collider other) // פגיעה של השחקן במטבעות
    {
        if (other.GetComponent<Player_movment>())
        {
            gameObject.GetComponent<AudioSource>().Play();
            transform.position = new Vector3(Destroyer.transform.position.x, Destroyer.transform.position.y +2, Destroyer.transform.position.z);
            Destroy(gameObject, 2);
        }

    }

    
}
