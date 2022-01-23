using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            TryGetAnyItem(0.8f);
        }
    }

    public void TryGetAnyItem(float searchRadius)
    {
        GameObject[] AllItems = GameObject.FindGameObjectsWithTag("Item");

        foreach(GameObject item in AllItems)
        {
            float dist = Vector2.Distance(transform.position, item.transform.position);

            //Get item
            if(dist <= searchRadius)
            {
                Destroy(item);

                return;
            }
        }
    }
}
