using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 10;
    public Vector2 turn;

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
      turn.x += Input.GetAxis("Mouse X");
      turn.y += Input.GetAxis("Mouse Y");
      transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);
      transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}