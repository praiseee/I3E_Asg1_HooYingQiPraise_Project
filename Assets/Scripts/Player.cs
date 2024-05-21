/*
 * Author: Hoo Ying Qi Praise
 * Date: 17/5/2023
 * Description: Assignment 1
 */

using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    //For Text on Canvas
    public GameObject textBox;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI blueCardText;
    public TextMeshProUGUI orangeCardText;
    public TextMeshProUGUI purpleCardText;

    //Text Scores and Points
    private int currentScore = 0;
    private int blueCardCount = 0;
    private int orangeCardCount = 0;
    private int purpleCardCount = 0; //hello

    public bool menuOpen = false;

    // Coin Score
    public void IncreaseScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        scoreText.text = currentScore.ToString();
    }

    // Blue Card count
    public void IncreaseBlueCardCount()
    {
        blueCardCount += 1;
        if (blueCardText != null)
        {
            blueCardText.text = blueCardCount.ToString();
        }
    }

    // Orange Card count
    public void IncreaseOrangeCardCount()
    {
        orangeCardCount += 1;
        if (orangeCardText != null)
        {
            orangeCardText.text = orangeCardCount.ToString();
        }
    }

    // Purple Card count
    public void IncreasePurpleCardCount()
    {
        purpleCardCount += 1;
        if (purpleCardText != null)
        {
            purpleCardText.text = purpleCardCount.ToString();
        }
    }

    //Determine whether conditions for opening a door are met.
    public int GetBlueCardCount()
    {
        return blueCardCount;
    }

    public int GetOrangeCardCount()
    {
        return orangeCardCount;
    }

    public int GetPurpleCardCount()
    {
        return purpleCardCount;
    }

    // To toggle between the menuBox using key 'E'
    public void OnMenu()
    {
        if (!menuOpen)
        {
            textBox.SetActive(true);
            menuOpen = true;
        }
        else
        {
            textBox.SetActive(false);
            menuOpen = false;
        }
    }

    void Start()
    {
        //Ensure box appears at the start of game
        textBox.SetActive(true);
    }

    void Update()
    {

    }
}
