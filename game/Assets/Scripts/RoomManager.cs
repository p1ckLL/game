using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject[] rooms;
    public int currentRoom;
    public void SetCurrentRoom(int index) {
        currentRoom = index;
        for (int i = 0; i < rooms.Length; i++) {
            rooms[i].SetActive(i == currentRoom);
        }
    }
    void Start()
    {
        SetCurrentRoom(1);
    }
}
