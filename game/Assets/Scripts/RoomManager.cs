using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject[] rooms;
    public int currentRoom = 0;

    public void ChangeCurrentRoom(int index) {
        currentRoom = index;

        for (int i = 0; i < rooms.Length; i++) {
            GameObject room = rooms[i];
            if (i != currentRoom) {
                room.SetActive(false);
            } else {
                room.SetActive(true);
            }
        }
    }
}
