using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 inicial;
    public GameObject player;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        inicial = player.transform.localPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit") && !player)
        {
            player = Instantiate(prefab, inicial, Quaternion.identity);



        }

    }
}
