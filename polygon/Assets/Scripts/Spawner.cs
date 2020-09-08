using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;

    public Hexagon hexagonPrefab;

    private float nextTimeToSpawn = 0f;

    public MoveByTouch moveByTouch;


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            //Debug.Log("Spawnrate: " + spawnRate);
            //Debug.Log("next Time to spawn: " + nextTimeToSpawn);
            Hexagon clone = Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            clone.moveByTouch = moveByTouch;
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
