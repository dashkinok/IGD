using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public List<Collectables> collectedObjects = new List<Collectables>();

    public void GetRidOfThingsIveAlreadyCollectedWhenSceneIsLoaded(RoomCollectables rC)
    {
        foreach (Collectables c in collectedObjects)
        {
            rC.DeleteTheCollectable(c);
        }
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.K))
    //    {
    //        collectedObjects.Add(Collectables.Knife);
    //    }
    //}
}
