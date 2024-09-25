using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveSpeedUp = 1f;
    public float speedUpDelay = 3f;
    private float speedUpTime;
    private bool hasBeenSpeedUp = false;

    private void Start()
    {
        speedUpTime = speedUpDelay;
    }

    // Update is called once per frame
    void Update()
    {
        var nextPosition = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        transform.SetPositionAndRotation(nextPosition, transform.rotation);

        if (!hasBeenSpeedUp)
        {
            speedUpTime -= Time.deltaTime;
            if (speedUpTime <= 0)
            {
                SpeedUp();
            }
        }
    }

    private void SpeedUp()
    {
        moveSpeed += moveSpeedUp;
        hasBeenSpeedUp = true;
    }
}
