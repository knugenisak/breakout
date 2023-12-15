using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class square : MonoBehaviour
{
    public static int ruta;

    int hp;        
    Material m;

    public int TakeDamage()

    {
        hp--;

        switch (hp)
        {
            case 1:
                m.color = Color.red;
                break;
            case 2:
                m.color = Color.cyan;
                break;
            case 3:
                m.color = Color.yellow;
                break;
            case 4:
                m.color = Color.green;
                break;
            case 5:
                m.color = Color.black;
                break;
        }

        if (hp == 0)
        { 
            Destroy(gameObject);
            ruta--;
        }
        return hp;
    }

    private void Start()
    {
        UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
        hp = UnityEngine.Random.Range(2, 7);
        m = GetComponent<Renderer>().material;
        ruta++;
        TakeDamage();
    }

    private void OnDestroy()
    {
       
        Destroy(m);
    }


}
