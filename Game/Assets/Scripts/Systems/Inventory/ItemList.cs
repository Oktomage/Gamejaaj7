using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ItemList : MonoBehaviour
{
    //Classe dos itens [Para manter mais de uma só informação]
    [System.Serializable]
    public class item
    {
        public string Item_name;

        public Sprite Item_sprite;
    }

    //Lista publica [serve para controle via inspector do unity]
    public item[] Items;
}
