using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saludo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Object[] objetos = GameObject.FindObjectsOfType((typeof(GameObject)));
        foreach (Object objeto in objetos)
        {
            Debug.Log(objeto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
