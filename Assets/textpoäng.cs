using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textpoäng : MonoBehaviour
{

    public static int poäng = 0;
    TextMesh T;

    // Start is called before the first frame update
    void Start()
    {
        T = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        T.text = $"Tappade bollar: {poäng}"; 
    }
}
