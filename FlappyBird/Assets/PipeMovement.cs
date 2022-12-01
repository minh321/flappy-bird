using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    public Transform bird;
    public Transform upperPoint;
    public Transform lowerPoint;
    public Transform leftMostPoint;
    public Transform rightMostPoint;
    [SerializeField] private GameManager gameManager;
    private bool isPassed = true;
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
                gameManager.GameOver();
                //Time.timeScale = 0;
            }
            if(bird.position.y > upperPoint.position.y)
            {
                gameManager.GameOver();
                //Time.timeScale = 0;
            }
        }
        /*if (bird.position.x > leftMostPoint.position.x && bird.position.x < rightMostPoint.position.x
            && bird.position.y > lowerPoint.position.y && bird.position.y < upperPoint.position.y)
        {
            isPassed = false;
        }
        else
        {
            isPassed = true;
        }
        do
        {
            Score.Instance.score++;
            break;
        } while ((isPassed == false));*/
    }

    private void FixedUpdate()
    {
        
    }
    
}
