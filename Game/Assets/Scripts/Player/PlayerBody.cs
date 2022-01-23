using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    public GameObject Backpack;

    [Header("Depedencies")]
    public PlayerMovement PlayerMove;
    public PlayerActions PlayerAct;

    public Inventory Inv;
}
