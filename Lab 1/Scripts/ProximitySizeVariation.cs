using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximitySizeVariation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject targetController;
    public GameObject targetSphere;
    public float proximityDistance = 4;

    void Start()
    {
        targetController = GameObject.Find("Controlador");
        targetSphere = GameObject.Find("Esfera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, targetController.transform.position) < proximityDistance) {
            transform.localScale = new Vector3(transform.localScale.x - 0.01F, transform.localScale.y - 0.01F, transform.localScale.z - 0.01F);
        }

        if (Vector3.Distance(transform.position, targetSphere.transform.position) < proximityDistance) {
            transform.localScale += new Vector3(0.01F, 0.01F, 0.01F); 
        }
    }
}
