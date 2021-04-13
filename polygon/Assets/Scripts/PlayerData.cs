[System.Serializable]
public class PlayerData
{
    public int highScore;
    
    
    public PlayerData (MoveByTouch moveByTouch)
    {
        
        highScore = moveByTouch.highScore;
    }
}
