using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;
    public int IdItemlist;

    #region Gets

    public void ImportSettings(Item anotherItem)
    {
        Name = anotherItem.Name;
        IdItemlist = anotherItem.IdItemlist;

        this.gameObject.name = Name;
    }

    #endregion
}
