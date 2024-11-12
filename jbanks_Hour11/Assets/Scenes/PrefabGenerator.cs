using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public float spaces = 2.0f; 
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 first = transform.position - new Vector3((spaces * (10 - 1)) / 2f, 0, 0);
        for (int i = 1; i <= 10; i++) {
             Vector3 spot = first + new Vector3(i * spaces, 0, 0);
             Instantiate(prefab, spot, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)){
             Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
             Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
