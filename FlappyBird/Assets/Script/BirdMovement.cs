using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private float flySpeed = 1f;
    [SerializeField] private float diveSpeed = 0.5f;
    public GameManager gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position= transform.position - new Vector3(0,diveSpeed,0)* Time.deltaTime;
        //transform.position = Vector3.down * Time.deltaTime;
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            transform.Translate(new Vector3(0,flySpeed,0) * 0.005f);
            Debug.Log(Time.deltaTime);
        }
        if(transform.position.y < -0.66f)
        {
            gameManager.GameOver();
        }
        
    }
}
