using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelNumberText : MonoBehaviour
{
    public Text Text;
    public Game Game;
    // Start is called before the first frame update
   private  void Start()
    {
        Text.text = "Level " + (Game.LevelIndex + 1).ToString();
    }

    
}
