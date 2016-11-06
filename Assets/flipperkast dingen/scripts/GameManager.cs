using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score=0;
    public int lives;
    public Text scorecounter;
    public Text LifeCounter;
    public Texture2D gameover;
    public bool checker;
      
    void Update()
    {
        OnGUI();//executes the void every frame


        if (lives == 0)
        {
            Destroy(GetComponent("deathzone"));
            
        }
                
    }

    void OnGUI()
    {
        GUILayout.Label("score = " + score);//shows the score amount on the UI  
        GUILayout.Label("lives = " + lives);//shows the lives amount on the UI
        if (lives <= 0)
        {
            Graphics.DrawTexture(new Rect(0, 0, 1920, 1080), gameover);//shows gameover screen when lives are 0 or less when the balls won't stop spawning :(
            checker = true;
        }
        else
        {
            checker = false;
        }
    }
        
}
