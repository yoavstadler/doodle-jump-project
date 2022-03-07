using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class lostCanvasScipt : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restartGame()
    {
        EditorSceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
