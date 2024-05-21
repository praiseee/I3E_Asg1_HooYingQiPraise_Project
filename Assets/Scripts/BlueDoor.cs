/*
 * Author: Hoo Ying Qi Praise
 * Date: 17/5/2023
 * Description: Assignment 1
 */

using UnityEngine;

public class BlueDoor : MonoBehaviour
{
    bool opened = false;
    public Congrats congratsScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !opened)
        {
            Player player = other.gameObject.GetComponent<Player>();
            if (player != null && player.GetBlueCardCount() >= 2)
            {
                OpenDoor();
                congratsScript.ShowCongrats();
            }
        }
    }

    void OpenDoor()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.y += -90f;
        transform.eulerAngles = newRotation;
        opened = true;
    }
}

