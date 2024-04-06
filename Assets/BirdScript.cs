using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public int upperLimit = 15;
    public int lowerLimit = -14;

    public bool GetLivingStatus()

        {
            return birdIsAlive;
        }

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); 

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerLimit || transform.position.y > upperLimit)
        {
            logic.gameOver();
            birdIsAlive = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }


}
