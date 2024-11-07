using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGameOver = blue.isSolved && green.IsSolved && red.isSolved && orange.IsSolved;
    }
    void onGUI()
    {
        Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
        GUI.Box (rect, "Game Over");
        Rect rect2 = newRect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
        GUI.Box (rect, "Good Job!");
    }
}
