using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleClick_ : MonoBehaviour
{
    public float maxTimer;
    public float maxDistance;
    public Vector2 clickPoint;
    float timer = 0;
    bool timeCounting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(timeCounting == false)
            {
                timeCounting = true;
                clickPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
            else
            {
                Vector2 currentClickPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                if(Vector2.Distance(currentClickPoint, clickPoint)< maxDistance)
                {
                    Debug.Log("Duplo Clique");
                }
                timer = 0;
                timeCounting = false;
            }
        }

        if(timeCounting)
        {
            timer += Time.deltaTime;
            if(timer > maxTimer)
            {
                timer = 0;
                timeCounting = false;
            }
        }
        
    }
}
