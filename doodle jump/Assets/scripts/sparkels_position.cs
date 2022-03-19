using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparkels_position : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int highestY = Player.GetComponent<Player_movment>().score / 100;
        transform.position = new Vector3(transform.position.x,highestY + 1, transform.position.z);

    }
}
