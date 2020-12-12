using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_ : MonoBehaviour
{
    public static Game_ Instance;
    public Player_ player;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

}
