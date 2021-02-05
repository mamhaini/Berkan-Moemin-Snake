using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
        public int scorePoint = 10;
        public int MaxScore;
        public Text ScoreText;

        // Start is called before the first frame update
        void Start()
        {
        ScoreText = GetComponent<Text>();
        ScoreText.text = "Score: " + scorePoint;
        }
    
        // Update is called once per frame
        void Update()
        {
             ScoreText.text = "Score: " + scorePoint;
        }
}
