using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    public GameObject Backpack;

    [Header("Conditions")]
    public bool CanWalk;

    public bool Stunned;
    public bool Stucked;

    [Header("Depedencies")]
    public PlayerMovement PlayerMove;
    public PlayerActions PlayerAct;

    public Inventory Inv;

    private void Start()
    {
        CanWalk = true;

        Stunned = false;
        Stucked = false;
    }

    #region Trap Effects

    public void GetStunnedByBanana()
    {
        Stunned = true;

        StartCoroutine(StunTimer(2));
    }

    IEnumerator StunTimer(float time)
    {
        CanWalk = false;

        yield return new WaitForSecondsRealtime(time);

        CanWalk = true;
        Stunned = false;
    }

    #endregion
}
