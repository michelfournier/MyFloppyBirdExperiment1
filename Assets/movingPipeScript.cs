using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    //public bool birdIsDead = false;

    //public BirdScript birdy;
    // Start is called before the first frame update
    void Start()
    {
        //birdy = GameObject.FindGameObjectWithTag("birdy").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {   //Vector3 bc scene still 3D \\ Time.deltaTime so it is not affected by FPS
     
        
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        
        
        
        if (transform.position.x < deadZone)
        {
            Debug.Log("Destroyed");
            Destroy(this.transform.parent.gameObject);
        }
    }
}
