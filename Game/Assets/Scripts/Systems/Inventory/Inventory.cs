using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [Header("Items")]
    [SerializeField]
    internal List<Item> Itens = new List<Item>();
    internal int index;

    internal int InventorySize;
    internal int InventoryAmmount;

    [Header("Conditions")]
    public bool Inventory_full;

    private void Start()
    {
        InventorySize = 3;

        //Clean inventory
        Itens.Clear();
    }

    void Update()
    {
        InvMove();
    }

    private void FixedUpdate()
    {
        //Get ammount of items in inventory
        InventoryAmmount = Itens.Count;

        if(InventoryAmmount < InventorySize)
        {
            Inventory_full = false;
        }
        else
        {
            Inventory_full = true;
        }
    }

    //Sistema de get sets [Muito util em listas]
    #region Get // Sets

    public void AddItem(Item itm)
    {
        Itens.Add(itm);
    }

    public void RemoveItem(Item itm)
    {
        Itens.Remove(itm);
    }

    #endregion

    void InvMove(){
        if(Itens.Count > 0)
        {
            //Up index
            if (index < (Itens.Count - 1))
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    index++;
                }
            }
            if (index > 0)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    index--;
                }
            }
        }
    }
}
