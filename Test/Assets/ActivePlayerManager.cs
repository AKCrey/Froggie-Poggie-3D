using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerManager : MonoBehaviour
{
    public ActivePlayer player1;
    public ActivePlayer player2;

    private ActivePlayer currentPlayer;
    
    public void Start()
    {
        /*player1.AssignManager(this);
        player2.AssignManager(this);
*/
        currentPlayer = player1;
    }

    public ActivePlayer GetCurrentPlayer()
    {
        return currentPlayer;
    }
    
    public void ChangeTurn()
    {
        if (player1 == currentPlayer)
        {
            currentPlayer = player2;
        }
        else if(player2 == currentPlayer)
        {
            currentPlayer = player1;
        }
    }
}
