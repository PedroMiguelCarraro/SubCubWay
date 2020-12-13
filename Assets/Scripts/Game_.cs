using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_ : MonoBehaviour
{
    public static Game_ Instance;
    public Player_ player;
    public int coins;
    public GameObject[] modules;
    public GameObject modulesObject;
    int moduleCount = 0;
    float moduleLength = 225;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }
    void Start() {
        SpawnModule();
        SpawnModule();
        SpawnModule();
    }

    void SpawnModule() {
        int randomModuleIndex = Random.Range(0, modules.Length);
        GameObject currentModule = Instantiate(modules[randomModuleIndex], Vector3.forward * moduleLength * moduleCount, Quaternion.identity);
        currentModule.transform.parent = modulesObject.transform;
        moduleCount++;
    }
    void Update() {
        if(player.transform.position.z > (moduleCount * moduleLength -2 * moduleLength) + moduleLength /4 )
        {
            SpawnModule();
            //if(modulesObject.transform.GetChild(1).gameObject != null){
                DestroyImmediate(modulesObject.transform.GetChild(1).gameObject);
            //}
        }
        
    }

}
