using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        Debug.Log("HOlaaaaaa");
        GameObject[] misiles = GameObject.FindGameObjectsWithTag("BioTorpedo");
        GameObject[] aliens = GameObject.FindGameObjectsWithTag("Alien");

        foreach (GameObject alien in aliens) {
            alien.transform.position = alien.transform.position + new Vector3(10, 0, 10);
        }

        foreach (GameObject misil in misiles) {
            misil.GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }

}
