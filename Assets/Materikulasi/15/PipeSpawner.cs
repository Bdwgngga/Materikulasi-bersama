using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnDelay = 1.5f;
    public float pipeMin = -1f;
    public float pipeMax = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Calling SpawnPipe for each interval of spawnDelay
        InvokeRepeating(nameof(SpawnPipe), 0f, spawnDelay);
    }

    // Spawning Pipe GameObject
    private void SpawnPipe()
    {
        // Randomize the y position of the new Pipe
        var pipeY = Random.Range(pipeMin, pipeMax);
        var position = transform.position;
        position.y = pipeY;
        // Cloning and creating a new pipe on the scene
        Instantiate(pipePrefab, position, Quaternion.identity);
    }
}