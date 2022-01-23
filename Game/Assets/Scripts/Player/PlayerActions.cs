using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [Header("Main")]
    public PlayerBody Body;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(Body.Inv.Inventory_full == false)
            {
                TryGetAnyItem(0.8f);
            }
        }
    }

    #region Interactions with inventory

    public void TryGetAnyItem(float searchRadius)
    {
        //Get all items in world
        GameObject[] AllItems = GameObject.FindGameObjectsWithTag("Item");

        //Search for items in radius
        foreach(GameObject Worlditem in AllItems)
        {
            //Get distances
            float dist = Vector2.Distance(transform.position, Worlditem.transform.position);

            //Get item
            if(dist <= searchRadius)
            {
                //Clone item
                GameObject itemClone = new GameObject();
                //Import Item settings
                itemClone.AddComponent<Item>();
                itemClone.GetComponent<Item>().ImportSettings(Worlditem.GetComponent<Item>());

                //Put item on backpack
                itemClone.transform.parent = Body.Backpack.transform;

                //Add item to list
                Body.Inv.AddItem(itemClone.GetComponent<Item>());

                //Delete world item
                Destroy(Worlditem);

                return;
            }
        }
    }

    #endregion
}
