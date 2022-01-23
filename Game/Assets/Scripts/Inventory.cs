using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //Atualizar script para poder pôr o item do ItemList no slot caso ele esteja vazio
    //Tornar o array Itens privado, e atualiza-lo por código
    public Sprite[] Itens;
    private int index;
    //Booleanos que informam que itens o jogador possui (Temporarios)
    private bool hasBanana;
    private bool hasSaco;


    // Update is called once per frame
    void Update()
    {
        InvMove();
        Debug.Log(index);
        gameObject.GetComponent<Image>().sprite = Itens[index];
    }
    void InvMove(){
        if(index < (Itens.Length - 1)){
            if (Input.GetKeyDown(KeyCode.R))
            {
                index++;
            }
        }
        if(index > 0){
            if (Input.GetKeyDown(KeyCode.F))
            {
                index--;
            }
        }
    }
}
