using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    public Text highScoreText;
    




    // Update is called once per frame
    void Start()
    {

        Debug.Log("Hi");
        PlayerData data = SaveSystem.LoadPLayer();
        //Debug.Log(data.highScore);
        if (data!= null)
        {
            highScoreText.text = data.highScore.ToString();
        }
        else
        {
            highScoreText.text = 00.ToString();
        }
    }
}
