using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityRunAway : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed = 10;
    public bool closeEnough = false;
    public float proximityDistance = 30;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Controlador");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < proximityDistance){
            closeEnough = true;
            Vector3 dir = transform.position - target.transform.position;
            dir.y = 0;
            transform.Translate(dir * moveSpeed * Time.deltaTime);
        }
        else {
            closeEnough = false;
        }
    }
}
