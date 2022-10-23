using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float horizontalMove;
    private float verticalMove;

    public delegate void colision();
    public event colision OnColisionA;
    public event colision OnColisionB;
    public event colision OnColisionC;
    
    public ObjetoA[] objetosA;
    public ObjetoB[] objetosB;
    public ObjetoC objetoC;
    public CharacterController player;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {  
        player.Move(new Vector3 (horizontalMove, 0 ,verticalMove) * speed * Time.deltaTime);
    }

    public void OnTriggerEnter(UnityEngine.Collider collision)
    {
        if (collision.gameObject.tag == "ObjetoA")
        {
            OnColisionA();
        }
        if (collision.gameObject.tag == "ObjetoB")
        {
            OnColisionB();
        }
        if (collision.gameObject.tag == "ObjetoC")
        {
            OnColisionC();
        }
    }
}
