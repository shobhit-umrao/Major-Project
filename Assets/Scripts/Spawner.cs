using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;

    public GameObject hexagonPrefab;

    private float nextTimeToSpawn = 0f;

    public MoveByTouch moveByTouch;


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            moveByTouch.currentScore += 10;
            //Debug.Log("Spawnrate: " + spawnRate);
            //Debug.Log("next Time to spawn: " + nextTimeToSpawn);
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
