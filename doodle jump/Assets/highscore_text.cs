using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore_text : MonoBehaviour
{
    public GameObject Player;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "your high score is:" + PlayerPrefs.GetInt("HS").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
