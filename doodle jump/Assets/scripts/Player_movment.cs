using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movment : MonoBehaviour
{
    Rigidbody rb;
    public float movementPower = 15;
    public int score;
    public int coinsCollected;
    float superJump = 15;
    public GameObject lostCanvas;
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementPower;
        Vector3 newMovment = rb.velocity;
        newMovment.x = horizontalMovement;
        rb.velocity = newMovment;
        int checkScore = Mathf.RoundToInt(transform.position.y * 100);
        if (checkScore > score)
        {
            score = checkScore;
        }
        
        if (gameObject.GetComponent<Player_movment>().coinsCollected >= 5 && Input.GetButtonDown("Jump"))
        {
            GetComponent<Player_movment>().coinsCollected -= 5;
            Vector3 newVelocity = rb.velocity;
            newVelocity.y += superJump;
            rb.velocity = newVelocity;
            print("jump");
        }

        if (gameObject.transform.position.x > 3.3f)
        {
            gameObject.transform.position = new Vector3(-4.4f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x < -4.4f)
        {
            gameObject.transform.position = new Vector3(3.3f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<coinCounterScript>())
        {
            coinsCollected++;
        }

        if (other.tag.Contains("Enemy"))
        {
            lostCanvas.SetActive(true);
            Destroy(gameObject);
            Destroy(fire);
        }
    }

   
  
        
    
}
