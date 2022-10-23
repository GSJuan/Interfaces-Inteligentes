using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoB : MonoBehaviour
{
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController.OnColisionA += OnColisionA;
        playerController.OnColisionC += OnColisionC;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 100;
        Debug.DrawRay(transform.position, forward, Color.black);
    }
    void OnColisionA()
    {
        //Debug.Log("Colision A");
        this.transform.localScale += new Vector3 (2F, 2F, 2F);
    }
    void OnColisionC()
    {
        //Debug.Log("Colision C");
        GameObject beacon = GameObject.FindGameObjectWithTag("Beacon");
        transform.LookAt(beacon.transform);
    }
}
