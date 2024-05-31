using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool SpaceShipIsAlive = true; 
   
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && SpaceShipIsAlive )
        { myRigidbody.velocity = Vector2.up * 10f;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        SpaceShipIsAlive = false;
    }
}
