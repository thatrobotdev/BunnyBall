using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver;

    public GameObject winnerUI;
    public GameObject player;

    private void Update()
    {
       // is the game over?
       if (gameOver)
        {
            GameOver();
        }
    }

    void GameOver() {
        player.GetComponent<Player>().enabled = false;
        Destroy(player.GetComponent<Rigidbody>());
        winnerUI.SetActive(true);
        StartCoroutine(NextLevel());

    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(2);
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
