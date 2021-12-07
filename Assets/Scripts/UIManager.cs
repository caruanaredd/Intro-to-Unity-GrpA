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

    // Start is called before the first frame update
    void Start()
    {
        // updates the score text :D
        UpdateScore(0);
    }

    public void UpdateScore(int points)
    {
        _scoreText.text = "Score: " + points;
    }

    public void UpdateLives(int points)
    {
        _livesImage.sprite = _lives[points];
    }
}
