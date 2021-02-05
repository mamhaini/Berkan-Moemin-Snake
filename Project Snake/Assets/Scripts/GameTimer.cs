using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 300f;

    [SerializeField]  Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            GameOver();
            currentTime = 0;
        }
    }
        // Game ends on timer 0 
    public void GameOver()
    {
        Debug.Break();  
    }
}
