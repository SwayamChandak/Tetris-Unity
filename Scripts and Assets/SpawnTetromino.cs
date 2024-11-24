using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTetromino : MonoBehaviour
{
    public GameObject[] Tetrominoes;
    private bool isGameOver = false; // Flag to check if the game is over

    void Start()
    {
        NewTetromino();
    }

    public void NewTetromino()
    {
        if (!isGameOver) // Only spawn if the game is not over
        {
            Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
        }
    }

    public void StopSpawning() // Method to stop spawning
    {
        isGameOver = true;
    }
}
