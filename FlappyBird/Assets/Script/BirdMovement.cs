using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private float flySpeed = 1f;
    [SerializeField] private float diveSpeed = 0.5f;
    [SerializeField] private AudioSource jumpSound;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        
        if (Input.GetMouseButtonDown(0))
        {
            transform.Translate(new Vector3(0,flySpeed,0) * 0.005f);
            jumpSound.Play();
            Debug.Log(Time.deltaTime);
        }
        if(transform.position.y < -0.7f)
        {
            GameManager.instance.GameOver();
        }
        
    }
}
