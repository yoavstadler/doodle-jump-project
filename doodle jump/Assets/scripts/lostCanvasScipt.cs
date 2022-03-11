using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class lostCanvasScipt : MonoBehaviour
{
    public GameObject menuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restartGame() // לולאת התחלת המשחק מחדש
    {
        EditorSceneManager.LoadScene("SampleScene");
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
