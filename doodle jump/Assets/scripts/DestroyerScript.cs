using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public GameObject lostCanvas;
    public int DestroyedPlatformes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Platform_script>())
            Destroy(other.gameObject);
        DestroyedPlatformes++;

        if (other.GetComponent<coinCounterScript>())
            Destroy(other.gameObject);
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player_movment>())
            lostCanvas.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
