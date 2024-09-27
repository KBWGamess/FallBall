using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int score;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
