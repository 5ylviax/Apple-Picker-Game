using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    //Prefab for instatniating apples
    public GameObject applePrefab;
    //Prefab for instatniating rotten apples
    public GameObject rottenApplePrefab;
    //Speed at which the AppleTree moves
    public float speed = 1f;
    //Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;
    //Chance that the AppleTree will change directions
    public float changeDirChance = 0.1f;
    //Seconds between Apple instantiations
    public float appleDropDelay = 1f;
    // Seconds between RottenApple instantiations
    public float rottenAppleDropDelay = 2f;


    // Start is called before the first frame update
    void Start()
    {
        // Start dropping apples
        Invoke("DropApple", 2f);
        Invoke("DropRottenApple", rottenAppleDropDelay);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }
    void DropRottenApple()
    {
        GameObject rottenApple = Instantiate<GameObject>(rottenApplePrefab);
        rottenApple.transform.position = transform.position;
        Invoke("DropRottenApple", rottenAppleDropDelay);
    }
    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Move left
        }
        // else if (Random.value < changeDirChance)
        // {
        //     speed *= -1; // Change Direction
        // } 
    }

    void FixedUpdate()
    {
        // Random direction changes are now time-based due to FixedUpdate()
        if (Random.value < changeDirChance)
        {
            speed *= -1; // Change Direction
        }
    }
}
