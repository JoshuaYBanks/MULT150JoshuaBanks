using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int TakeDamage(int damageAmount){
            int health = 100;
            return health - damageAmount;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
