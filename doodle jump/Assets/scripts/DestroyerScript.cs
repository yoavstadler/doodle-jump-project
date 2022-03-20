using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    // הגדרת משתנים
    public GameObject lostCanvas;
    public int DestroyedPlatformes;
    public GameObject NewHighScore;
    public GameObject Player;
    public GameObject BackGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) // הגדרת לולאה של כניסת הדיסטרוייר אל דברים אחרים
    {
        if (other.GetComponent<Platform_script>())
            Destroy(other.gameObject);
        DestroyedPlatformes++; // העלאת כמות הפלטפורמות שנהרסו לקביעת רמת הקושי של המשחק

        if (other.GetComponent<coinCounterScript>())
            Destroy(other.gameObject);
        
    }

    private void OnTriggerExit(Collider other) // הגדרת לולאה של יציאת השחקן מהדיסטרוייר
    {
        if (other.GetComponent<Player_movment>())
        {
            lostCanvas.SetActive(true); // הפעלת מסך הפסד
            updateHighScore();
            GetComponent<AudioSource>().Play();
            BackGround.GetComponent<AudioSource>().Pause();
        }
    }
     void updateHighScore()
    {
        int endscore = Player.GetComponent<Player_movment>().score; ;
        if (endscore > PlayerPrefs.GetInt("HS"))
        {
            PlayerPrefs.SetInt("HS", endscore);
            NewHighScore.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
