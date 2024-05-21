
/*
 * Author: Hoo Ying Qi Praise
 * Date: 17/5/2023
 * Description: Assignment 1
 */

using UnityEngine;
using TMPro;

public class Congrats : MonoBehaviour
{

    public GameObject congratsCanvas; 
    public GameObject menu;
    public TextMeshProUGUI[] textElements;

    public void ShowCongrats()
    {
        // Activate the congrats canvas
        congratsCanvas.SetActive(true);
        
        // Activate the menu (if needed)
        menu.SetActive(true);
    }
}
