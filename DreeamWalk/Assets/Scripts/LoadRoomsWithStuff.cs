using System.Collections.Generic;
using UnityEngine;

public class LoadRoomsWithStuff : MonoBehaviour {

    public List<GameObject> rooms = new List<GameObject>();
    private GameObject _loadedRoom;
    private Inventory _myInv;

    private int _roomIndex;
    public int roomIndex
    {
        get
        {
            return _roomIndex;
        }
        set
        {
            Destroy(_loadedRoom);
            _roomIndex = value;
            _loadedRoom = Instantiate(rooms[_roomIndex]);
            Debug.Log(_loadedRoom.name);
            if (_loadedRoom.gameObject.name != "Inventory(Clone)")
            {
                _myInv.GetRidOfThingsIveAlreadyCollectedWhenSceneIsLoaded(_loadedRoom.GetComponent<RoomCollectables>());
            }
            else
            {
                if (_myInv.collectedObjects != null)
                {
                    if (_myInv.collectedObjects.Count > 0)
                    {
                        _loadedRoom.GetComponent<RoomCollectables>().ShowItemsInInventory(_myInv.collectedObjects);

                    }
                }
            }
        }
    }

    private void Start()
    {
        _myInv = GetComponent<Inventory>();
        roomIndex = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            roomIndex = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            roomIndex = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            roomIndex = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            roomIndex = 3;
        }
    }

    public void LoadRoom(int desiredRoomNumber)
    {
        roomIndex = desiredRoomNumber;
    }

}
