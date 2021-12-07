using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

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
}
