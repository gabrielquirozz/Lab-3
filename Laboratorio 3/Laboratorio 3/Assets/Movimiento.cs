using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 2;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad)*Time.deltaTime, Space.World);
        
    }
}
