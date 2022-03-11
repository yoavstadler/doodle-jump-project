using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    // הגדרת משתנים
    public Text scoreText;
    public Text coinsCounter;
    public Player_movment player_Movment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score:" + player_Movment.score.ToString(); // הבאת המשתנים מטבעות וניקוד למסך המשחק
        coinsCounter.text = "coins collected:" +player_Movment.coinsCollected.ToString(); 
       

    }
}
