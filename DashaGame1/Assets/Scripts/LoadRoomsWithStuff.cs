using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadRoomsWithStuff : MonoBehaviour {

    public List<GameObject> rooms = new List<GameObject>();
    public GameObject _loadedRoom;
    private Inventory _myInv;
    public Text countdown; 
  
   float timeLeft = 100.0f;
     
     public Text text;

   

    public int _roomIndex;
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
     Mathf.Round(timeLeft); 

    }



    public void Update()

    {
       if( roomIndex == 6 || roomIndex == 7 || roomIndex == 8 || roomIndex == 12 ){

        timeLeft -= Time.deltaTime;

        
    }

    

 
if (Input.GetKeyDown(KeyCode.I))
        {
         roomIndex = 1;
        }

  if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (roomIndex == 0) //start menu to bedroom
        {
            roomIndex = 2; 
        }
        

        if (roomIndex == 2 && hit.collider.gameObject.tag  == "Diary" ) //Bedroom to diary
        {
            roomIndex = 11;  
        } 
         if (roomIndex == 11 && hit.collider.gameObject.tag  == "Bedroom" ) //Bedroom to diary
        {
            roomIndex = 2;  
        } 

        if (roomIndex == 2 && hit.collider.gameObject.tag  == "Kitchen" ) //Bedroom to kitchen
        {
            roomIndex = 3;  
        } 
        if (roomIndex == 3 && hit.collider.gameObject.tag == "Bedroom") //kitchen to bedroom
        {
            roomIndex = 2;
        } 
        if (roomIndex == 3 && hit.collider.gameObject.tag == "Fridge") //Kitchen to Fridge
        {
            roomIndex = 4;
        }
        
       

       
        if (roomIndex == 1 && hit.collider.gameObject.tag == "Kitchen") //Inv to kitchen
        {
            roomIndex = 3;
        }
        if (roomIndex == 1 && hit.collider.gameObject.tag == "Binary") //InsideFridge to Binary
        {
            roomIndex = 6;
        }
        if (roomIndex == 4 && hit.collider.gameObject.tag == "Kitchen") //Fridge to kitchen
        {
            roomIndex = 3;
        }
        if (roomIndex == 4 && hit.collider.gameObject.tag == "FridgeInside") //FridgeCloseUp to InsideFridge
        {
            roomIndex = 5;
        }
        if (roomIndex == 5 && hit.collider.gameObject.tag == "Fridge") //InsideFridge to FridgeCloseUp
        {
            roomIndex = 4;
        }

        if (roomIndex == 5 && hit.collider.gameObject.tag == "Binary") //InsideFridge to Binary
        {
            roomIndex = 6;
        }
        if (roomIndex == 5 && hit.collider.gameObject.tag == "died") //InsideFridge to Death Screen
        {
            roomIndex = 9;
        }

        if (roomIndex == 9 && hit.collider.gameObject.tag == "quit") //Death Screen to quit to Quit
        {
            Application.Quit();
        }
 


        if (roomIndex == 6 && hit.collider.gameObject.tag == "Bomb") //Binary to Bomb
        {
            roomIndex = 7; 
            text.text = "ANYTIME NOW: ";  
        }
        if (roomIndex == 6 && hit.collider.gameObject.tag == "Decode") //Binary to Bomb
        {
            roomIndex = 12;    
        }
        if (roomIndex == 12 && hit.collider.gameObject.tag == "Binary") //Binary to Bomb
        {
            roomIndex = 6;    
        }
        if (roomIndex == 7 && hit.collider.gameObject.tag == "Binary") //Bomb to Binary
        {
            roomIndex = 6;
        }
         if (roomIndex == 6 && hit.collider.gameObject.tag == "RiddleBinary") //Binary to Riddle
        {
            roomIndex = 8;
        }
        if (roomIndex == 8 && hit.collider.gameObject.tag == "Binary") //Binary to Riddle
        {
            roomIndex = 6;
        }
        
        
    }

}
    public void LoadRoom(int desiredRoomNumber)
    {
        roomIndex = desiredRoomNumber;
    }

}
