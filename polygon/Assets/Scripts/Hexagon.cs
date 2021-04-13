using UnityEngine;
public class Hexagon : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkSpeed = 2f;
    public MoveByTouch moveByTouch;
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 359f);
        transform.localScale = Vector3.one * 17f;
    }
    // Update is called once per frame
    void Update()
    {   
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if(transform.localScale.x <= 0.1f)
        {       
            //Debug.Log("Score in Hexagon Script" + GameObjectPlayer.GetComponent<MoveByTouch>().currentScore);
            //GameObjectPlayer.GetComponent<MoveByTouch>().SavePlayer();

            //Debug.Log("Before destroyed");
            Destroy(gameObject);
            //Debug.Log("After destroyed");
            //GameObject.Destroy(gameObject);
            //Debug.Log("After gameObject.Destroy");

            moveByTouch.currentScore += 10;
            //Debug.Log("Shrink Speed: " + shrinkSpeed);

        }
    }
}
