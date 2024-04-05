using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public float moveSpeed = 5;
 

    // Start is called before the first frame update
    void Start()
    {   // logic = LogicManager.LogicScript -·> become object of class LogicScript and can then use methods from the LogicManager script (LogicScript)
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
       //Vector3 bc scene still 3D \\ Time.deltaTime so it is not affected by FPS
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime; 

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
        Debug.Log("+1");

    }
}
