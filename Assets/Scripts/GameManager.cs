using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool _isGameOver = false;

    // Update is called once per frame
    void OnRestart()
    {
        // if the R key was pressed AND is game over
        // reload the level
        if (_isGameOver == true)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void GameOver()
    {
        _isGameOver = true;
    }
}
