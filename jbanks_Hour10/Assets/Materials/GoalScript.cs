using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isSolved = false;
    void OnTriggerEnter (Collider collider) {
        GameObject.collideWith = colider.gameObject;
        if (collidedWith.tag == gameObject.tag) {
            isSolved = true;
            GetComponent<Light>.enabled = false;
            Destroy (collideWith);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
