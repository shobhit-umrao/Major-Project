using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveByTouch : MonoBehaviour
{
    public float moveSpeedTouch = 600f;

    float movementTouch = 0f;

    public int currentScore=0;
    public int highScore;
    

    void Start()
    {
        this.LoadPlayer();
    }

    public void SavePlayer()
    {
        if (highScore <= currentScore)
            highScore = currentScore;
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPLayer();

        highScore = data.highScore;
    }

    // Update is called once per frame
    void Update()
    {

        movementTouch = Input.GetAxisRaw("Horizontal");
        if (Input.touchCount > 0)
        {
           
            for (int i = 0; i < Input.touchCount ; i++)
            {
                Touch touch = Input.GetTouch(i);
                if(touch.position.x < Screen.width / 2 && !(touch.position.x < Screen.width / 4))
                {
                    movementTouch = -1;
                    moveSpeedTouch = 600f;
                }
                if (touch.position.x < Screen.width / 2 && touch.position.x < Screen.width / 4)
                {
                    movementTouch = -1;
                    moveSpeedTouch = 550f;
                }
                if (touch.position.x > Screen.width / 2 && !(touch.position.x > Screen.width * 3 / 4))
                {
                    movementTouch = 1;
                    moveSpeedTouch = 600f;
                }
                if (touch.position.x > Screen.width / 2 && touch.position.x > Screen.width * 3 / 4)
                {
                    movementTouch = 1;
                    moveSpeedTouch = 550f;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movementTouch * Time.fixedDeltaTime * -moveSpeedTouch);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // not needed I guess..Destroy(gameObject);
        //
        

        

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SavePlayer();
    }
}
