using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCollectables : MonoBehaviour {

    public List<GameObject> CollectablesInScene = new List<GameObject>();

    public void DeleteTheCollectable (Collectables c)
    {
        foreach (GameObject gO in CollectablesInScene)
        {
            if (gO.GetComponent<Collectable>().myCollectableType == c)
                Destroy(gO);
        }
    }

    public void ShowItemsInInventory(List<Collectables> c)
    {
        //Vector3 locToShow = new Vector3(itemsToShowIndex % 3, Mathf.Floor(itemsToShowIndex / 3), 0);
        //Instantiate(gO, locToShow, Quaternion.identity, this.transform);
        //itemsToShowIndex++;
        for (int i = 0; i < c.Count; i++)
        {
            Vector3 locToShow = new Vector3(i % 3, Mathf.Floor(i / 3), 0);
            GameObject gO;
            if (c[i] == Collectables.Book)
            {
                gO = Resources.Load("Book") as GameObject;
            }
            else if (c[i] == Collectables.Key)
            {
                gO = Resources.Load("Key") as GameObject;
            }
            else 
            {
                gO = Resources.Load("Knife") as GameObject;
            }
            Instantiate(gO, locToShow, Quaternion.identity, this.transform);
        }

    }
}

public enum Collectables { Knife, Key, Book}
