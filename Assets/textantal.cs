using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textantal : MonoBehaviour
{
    public static int antal = 1;
    TextMesh T;

    // Start is called before the first frame update
    void Start()
    {
        T = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        T.text = $"Antal bollar: {antal}";
    }
}
