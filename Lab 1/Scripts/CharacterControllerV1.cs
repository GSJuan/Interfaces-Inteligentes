using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 10;
    public float turnSpeed = 1;
    public float turn = 0;

    // Start is called before the first frame update
    void Start()
    {
      Component transform = this.GetComponent<Transform>();
      
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");
      turn += Input.GetAxis("Turn");
      transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);
      transform.localRotation = Quaternion.Euler(0, turn * turnSpeed, 0);

    }
}