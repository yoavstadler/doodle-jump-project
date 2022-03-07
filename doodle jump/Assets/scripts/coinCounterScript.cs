using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCounterScript : MonoBehaviour
{
   
    public GameObject coins;
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
            Destroy(coins.gameObject);
        

    }

    
}
