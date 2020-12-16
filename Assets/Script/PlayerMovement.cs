using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rgb;
    [SerializeField] private float forwordForce = 3000f;
    [SerializeField] private float sideMovement = 100f;
    private bool goLeft = false;
    private bool goRight = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey("d"))
        {
            goRight = true;
        }
        if (Input.GetKey("a"))
        {
            goLeft = true;
        }
    }

    void FixedUpdate()
    {
        rgb.AddForce(0, 0, forwordForce * Time.deltaTime);

        if (goRight == true)
        {
            rgb.AddForce(sideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            goRight = false;
        }
        if(goLeft == true)
        {
            rgb.AddForce(-sideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            goLeft = false;
        }
        if(rgb.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
