using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform bird;
    [SerializeField] private Transform upperPoint;
    [SerializeField] private Transform lowerPoint;
    [SerializeField] private Transform leftMostPoint;
    [SerializeField] private Transform rightMostPoint;
    
   
    private void Start()
    {
        bird = FindObjectOfType<BirdMovement>().transform;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(bird.position.x > leftMostPoint.position.x && bird.position.x < rightMostPoint.position.x)
        {
            if(bird.position.y < lowerPoint.position.y)
            {
                GameManager.instance.GameOver();
                //Time.timeScale = 0;
            }
            if(bird.position.y > upperPoint.position.y)
            {
                GameManager.instance.GameOver();
                //Time.timeScale = 0;
            }
        }
        
    }
    
}
