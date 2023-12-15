using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textrutor : MonoBehaviour
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
        T.text = $"Antal rutor kvar: {square.ruta}";
    }
}
