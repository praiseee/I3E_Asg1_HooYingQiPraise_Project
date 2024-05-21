/*
 * Author: Hoo Ying Qi Praise
 * Date: 17/5/2023
 * Description: Assignment 1
 */

using UnityEngine;

public class PurpleDoor : MonoBehaviour
{
    bool opened = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !opened)
        {
            Player player = other.gameObject.GetComponent<Player>();
            if (player != null && player.GetPurpleCardCount() >= 2)
            {
                OpenDoor();
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

