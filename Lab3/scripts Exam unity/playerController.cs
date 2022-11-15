using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float horizontalMove;
    private float verticalMove;
    public float speed = 5f;
    public int points = 0;

    public CharacterController player;
    public Transform teleportTarget;

    private Vector3 _startingPosition;

    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 3.5f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;

//    public delegate void colision();
  //  public event colision AlienDestroyerHit;

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
        transform.Translate(new Vector3(horizontalMove, 0, verticalMove) * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {  
        //player.Move(new Vector3 (horizontalMove, 0 ,verticalMove) * speed * Time.deltaTime);
        //transform.Translate(new Vector3(horizontalMove, 0, verticalMove) * speed * Time.deltaTime);        
    }

    public void OnTriggerEnter(UnityEngine.Collider collision) {
        if (collision.gameObject.tag == "Alien Fighter")
        {
            points += 10;
        }
        if(collision.gameObject.tag == "Alien Destroyer") {
            player.transform.position = teleportTarget.transform.position;
        }
    }
}
