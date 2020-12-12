using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector2 initialTouch; 
    Vector2 releaseTouch; 
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0))
        {
            initialTouch = new Vector2( Input.mousePosition.x, Input.mousePosition.y );
        }
        if( Input.GetMouseButtonUp(0))
        {
            releaseTouch = new Vector2( Input.mousePosition.x, Input.mousePosition.y );
            direction = releaseTouch - initialTouch;
            direction.Normalize();
            direction = new Vector2( Mathf.Round(direction.x), Mathf.Round(direction.y));
            if( direction == Vector2.up){
                Debug.Log("UP");
            }
            if( direction == Vector2.down){
                Debug.Log("DOWN");
            }
            if( direction == Vector2.left){
                Debug.Log("LEFT");
            }
            if( direction == Vector2.right){
                Debug.Log("RIGHT");
            }
        }
        
    }
}
