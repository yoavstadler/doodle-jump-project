using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_script : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = Player.GetComponent<Rigidbody>();
        if (rb.velocity.y > 7)
        {
            transform.position = new Vector3(Player.transform.position.x +0.47f ,Player.transform.position.y -1.72f , -0.3f);
        }
        else
        {
            transform.position = new Vector3(Player.transform.position.x + 0.47f , Player.transform.position.y - 1.75f , 0.1f);
        }

      
    }
}
