using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    GameSession gameSession;
    [SerializeField] TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();

        if (gameSession.CurrentLevel == 0)
            gameOverText.text = "Game Over";
        else
            gameOverText.text = "Congratulations!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
