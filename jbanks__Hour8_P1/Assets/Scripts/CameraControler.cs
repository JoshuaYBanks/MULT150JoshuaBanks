using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject target;
    void Start()
    {
        target = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal")){
            target.transform.Translate(1f, 0f, 0f);
        }
        if(Input.GetAxis("Vertical")){
            target.transform.Translate(0f, 1f, 0f);
        }
    }
}
