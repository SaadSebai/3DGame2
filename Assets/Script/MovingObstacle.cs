using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed = 5f;
    float obstaclePosition;

    private void Start()
    {
        obstaclePosition = this.transform.position.x;
    }
    private void Update()
    {
        this.transform.Translate(obstacleSpeed * Time.deltaTime, 0, 0, Space.World);
        if (obstaclePosition - this.transform.position.x >= 4 || obstaclePosition - this.transform.position.x <= -4)
        {
            obstacleSpeed = obstacleSpeed * -1;
        }
        
    }
}
