using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

    [SerializeField]
    private Image _livesImage;

    [SerializeField]
    private Sprite[] _lives;

    [SerializeField]
    private GameObject _gameOverText;

    [SerializeField]
    private GameObject _restartText;

    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // updates the score text :D
        UpdateScore(0);
        _gameOverText.SetActive(false);
        _restartText.SetActive(false);

        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void UpdateScore(int points)
    {
        _scoreText.text = "Score: " + points;
    }

    public void UpdateLives(int points)
    {
        _livesImage.sprite = _lives[points];
        if (points <= 0)
        {
            _gameOverText.SetActive(true);
            _restartText.SetActive(true);
            _gameManager.GameOver();
        }
    }
}
