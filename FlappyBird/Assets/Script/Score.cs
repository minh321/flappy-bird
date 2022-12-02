using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    public static Score Instance { get; set; }
    [SerializeField] private TextMeshProUGUI textScore;
    private int score;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    private void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
        textScore.text = score.ToString();
    }
    private void FixedUpdate()
    {
        score++;
    }
    private IEnumerable addScore()
    {
        yield return new WaitForSeconds(1);
        score++;
    }
}
