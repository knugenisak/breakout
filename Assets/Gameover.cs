using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class Gameover : MonoBehaviour
{
    
    TextMesh T;

    // Start is called before the first frame update
    void Start()
    {
        T = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (square.ruta == 0)
        {
            T.text = "Game over";
            Time.timeScale = 0;
        }
    }
}
