using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana_trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerBody>().GetStunnedByBanana();

            Destroy(this.gameObject);
        }
    }
}
