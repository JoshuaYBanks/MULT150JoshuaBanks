using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i <29){
             Debug.Log(i);
             i++;
        }
        Debug.Log("Its my birthday");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
