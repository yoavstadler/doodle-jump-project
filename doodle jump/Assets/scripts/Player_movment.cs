using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movment : MonoBehaviour
{
    // הגדרת משתנים
    Rigidbody rb;
    public float movementPower = 15;
    public int score;
    public int coinsCollected;
    float superJump = 15;
    public GameObject lostCanvas;
    public GameObject fire;
    public GameObject NewHighScore;
    public GameObject BackGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // הגדרת משתנה
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementPower; // הגדרת תנועת השחקן לפי אינפוט 
        Vector3 newMovment = rb.velocity;
        newMovment.x = horizontalMovement;
        rb.velocity = newMovment;
        int checkScore = Mathf.RoundToInt(transform.position.y * 100); // הגדרת ניקוד
        if (checkScore > score)
        {
            score = checkScore;
        }
        
        if (gameObject.GetComponent<Player_movment>().coinsCollected >= 5 && Input.GetButtonDown("Jump")) // לולאת קפיצה לפי כמות מטבעות של השחקן
        {
            GetComponent<Player_movment>().coinsCollected -= 5;
            Vector3 newVelocity = rb.velocity; 
            newVelocity.y += superJump; //שינוי מהירות של השחקן
            rb.velocity = newVelocity;
            print("jump");
            fire.GetComponent<AudioSource>().Play();
            
        }

        if (gameObject.transform.position.x > 3.3f) // יצרית גבולות של השחקן לפי המיקום שלו בציר האיקס
        {
            gameObject.transform.position = new Vector3(-4.4f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x < -4.4f)
        {
            gameObject.transform.position = new Vector3(3.3f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetInt("HS", 0);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<coinCounterScript>()) // מעקב אחרי כמות המטבעות
        {
            coinsCollected++;
        }

        if (other.tag.Contains("Enemy")) // הריסת אובייקטים כאשר השחקן נפסל
        {
            lostCanvas.SetActive(true);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z -10);
            Destroy(fire);
            BackGround.GetComponent<AudioSource>().Pause();
            GetComponent<AudioSource>().Play();
            

            updateHighScore();
        }
    }

    void updateHighScore()
    {
        int endscore = score;
        if (endscore > PlayerPrefs.GetInt("HS"))
        {
            PlayerPrefs.SetInt("HS", endscore);
            NewHighScore.SetActive(true);

        }
    }

   
  
        
    
}
