using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSizeSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other) {
      if (other.gameObject.tag == "Controlador") {
        transform.localScale += new Vector3(0.1F, 0.1F, 0.1F); 
        other.gameObject.GetComponent<CharacterController>().points += 1;
      }

      if (Input.GetKey(KeyCode.Space)) {
        Vector3 dir = transform.position - other.gameObject.transform.position;
        dir.y = 0;
        transform.Translate(dir);
      }
    }
}
