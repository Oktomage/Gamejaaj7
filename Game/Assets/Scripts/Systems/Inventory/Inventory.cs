using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [Header("Items")]
    [SerializeField]
    internal List<Sprite> Itens = new List<Sprite>();
    internal int index;

    //Booleanos que informam que itens o jogador possui (Temporarios)
    private bool hasBanana;
    private bool hasSaco;


    private void Start()
    {
        //Clean inventory
        Itens.Clear();
    }

    void Update()
    {
        InvMove();
        //Debug.Log(index);

        //Get item sprite
        if(Itens.Count > 0)
        {
            gameObject.GetComponent<Image>().sprite = Itens[index];
        }
    }

    //Sistema de get sets [Muito util em listas]
    #region Sets

    public void AddItem(Sprite item)
    {
        Itens.Add(item);
    }

    public void RemoveItem(Sprite item)
    {
        Itens.Remove(item);
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
