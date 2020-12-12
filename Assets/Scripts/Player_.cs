using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ : MonoBehaviour
{
    public float speed;
    public float targetX;
    public float laneWidth;
    public int currentLane = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetX = currentLane * laneWidth;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), 0.2f);
    }

    public void MoveLeft()
    {
        if(currentLane >=0 ){
            currentLane--;
        }
    }

    public void MoveRight()
    {
        if(currentLane <=0 ){
            currentLane++;
        }
    }
}
