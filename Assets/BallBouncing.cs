//Written by Natalie Dehwe 
//09/18


using UnityEngine;

public class BallBouncing : MonoBehaviour
{
    public float speed = 2f;     // how fast it bounces
    public float height = 1f;    // how high it bounces

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;  // remember the starting position
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Abs(Mathf.Sin(Time.time * speed) * height);
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}