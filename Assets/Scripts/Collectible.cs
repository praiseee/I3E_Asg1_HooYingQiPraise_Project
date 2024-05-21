/*
 * Author: Hoo Ying Qi Praise
 * Date: 17/5/2023
 * Description: Assignment 1
 */

using System.Collections;
using TMPro;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public TextMeshProUGUI cardText;

    void Collected()
    {
        // Check to see if code is executed
        Debug.Log(gameObject.name + "collected.");
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        int coinValue = 0;

        // Check if object collided is tagged "player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the Player component from the collided object
            Player player = collision.gameObject.GetComponent<Player>();

            //yellowCoin
            if (gameObject.CompareTag("yellowCoin"))
            {
                coinValue = 2;
                Debug.Log("Collected a yellow coin. Value: " + coinValue);
            }

            //redCoin
            else if (gameObject.CompareTag("redCoin"))
            {
                coinValue = 4;
                Debug.Log("Collected a red coin. Value: " + coinValue);
            }

            //blueCard
            else if (gameObject.CompareTag("blueCard"))
            {
                player.IncreaseBlueCardCount();
                if (cardText != null)
                {
                    cardText.text = player.GetBlueCardCount().ToString();
                    Debug.Log("Collected a blue card. Total blue cards: " + player.GetBlueCardCount());
                }
                else
                {
                    Debug.LogError("cardText is not assigned in the inspector."); //For me to knpw cardText is not assigned
                }
            }

            //orangeCard
            else if (gameObject.CompareTag("orangeCard"))
            {
                player.IncreaseOrangeCardCount();
                if (cardText != null)
                {
                    cardText.text = player.GetOrangeCardCount().ToString();
                    Debug.Log("Collected an orange card. Total orange cards: " + player.GetOrangeCardCount());
                }
                else
                {
                    Debug.LogError("cardText is not assigned in the inspector.");
                }
            }

            //purpleCard
            else if (gameObject.CompareTag("purpleCard"))
            {
                player.IncreasePurpleCardCount();
                if (cardText != null)
                {
                    cardText.text = player.GetPurpleCardCount().ToString();
                    Debug.Log("Collected a purple card. Total purple cards: " + player.GetPurpleCardCount());
                }
                else
                {
                    Debug.LogError("cardText is not assigned in the inspector.");
                }
            }

            // Increase the player's score by the coin's value
            player.IncreaseScore(coinValue);
            Collected();
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
