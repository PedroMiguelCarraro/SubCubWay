using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Player_ : MonoBehaviour
{
    public float speed;
    public float targetX;
    public float laneWidth;
    public int currentLane = 0;
    public int coins;
    //public TextMeshProGUI contador;
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
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

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            coins++;
            //contador.text = coins.ToString();
            Destroy(other.gameObject);
        }
    }
}
