using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PipeSpwaning : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    public bool birdIsDead = false;

    public BirdScript birdy;

    

    // Start is called before the first frame update
    void Start()
    {
        birdy = GameObject.FindGameObjectWithTag("birdy").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdIsDead == false)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;     
            }
            else 
            {
                spawnPipe();
                timer = 0;
            }
                  
        }
    }
               
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
