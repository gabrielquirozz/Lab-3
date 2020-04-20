using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    float velocidad;
    float velAngular;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 2;
        velAngular = 45;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, velAngular, 0) * Time.deltaTime);
        
    }
}
