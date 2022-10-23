using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoA : MonoBehaviour
{
    public PlayerController playerController;
    public float jumpAmount = 10;
    public bool isJumping = false;
    

    // Start is called before the first frame update
    void Start()
    {
        playerController.OnColisionB += OnColisionB;
        playerController.OnColisionC += OnColisionC;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.magenta);  
    }
    void OnColisionB()
    {
        //Debug.Log("Colision B");
        GameObject objetoC = GameObject.FindGameObjectWithTag("ObjetoC");
        Vector3 heading = objetoC.transform.position - transform.position;
        heading.y = 0;
        transform.position += heading / 2;
    }
    void OnColisionC()
    {
        //Debug.Log("Colision C");
        GetComponent<Renderer>().material.color = Color.green;
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        
    }
}
