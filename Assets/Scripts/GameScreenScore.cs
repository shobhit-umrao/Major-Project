using UnityEngine;
using UnityEngine.UI;

public class GameScreenScore : MonoBehaviour
{
    public Text currScore;
    public MoveByTouch moveByTouch;

   
    void Update()
    {
        currScore.text = moveByTouch.currentScore.ToString();
        
        

        //currScore.text = moveByTouch.currentScore.ToString();
        //GameObject hexagon = GameObject.Find("Hexagon");
        //PlayerData data = SaveSystem.LoadPLayer();
        //Hexagon playerScript = hexagon.GetComponent<Hexagon>();

        //Debug.Log(playerScript.highScore);
        //currScore.text = playerScript.highScore.ToString();
    }
}
