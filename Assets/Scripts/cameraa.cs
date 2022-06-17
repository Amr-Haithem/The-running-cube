using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform player;
    public Vector3 offset;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position+offset;

        
    }
}
