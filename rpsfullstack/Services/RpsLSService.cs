using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using rpsfullstack.Controllers;
namespace rpsfullstack.Controllers
{
    public class RpsLSService
    {
        public string Game(string userMove)
        {
            Random random = new Random();
            string[] moves = { "rock", "paper", "scissors", "lizard", "spock" };
            string cpuMove = moves[random.Next(moves.Length)];

            if (cpuMove == "rock")
            {
                if (userMove == "paper" || userMove == "spock")
                    
                    return $"CPU chose {cpuMove}. You Win!";
                else if (cpuMove == userMove)
                    return $"CPU chose {cpuMove}. Draw.";
                else
                    return $"CPU chose {cpuMove}. CPU Wins.";
            }
                    
            else if (cpuMove == "paper")
            {
                if (userMove == "lizard" || userMove == "scissors")
                    return $"CPU chose {cpuMove}. You Win!";
                else if (cpuMove == userMove)
                    return $"CPU chose {cpuMove}. Draw.";
                else
                    return $"CPU chose {cpuMove}. CPU Wins.";
            }
            else if (cpuMove == "scissors")
            {
                if (userMove == "rock" || userMove == "spock")
                    return $"CPU chose {cpuMove}. You Win!";
                else if (cpuMove == userMove)
                    return $"CPU chose {cpuMove}. Draw.";
                else
                    return $"CPU chose {cpuMove}. CPU Wins.";
            }
            else if (cpuMove == "lizard")
            {
                if (userMove == "rock" || userMove == "scissors")
                    return $"CPU chose {cpuMove}. You Win!";
                else if (cpuMove == userMove)
                    return $"CPU chose {cpuMove}. Draw.";
                else
                    return $"CPU chose {cpuMove}. CPU Wins.";
            }
            else // spock
            {
                if (userMove == "paper" || userMove == "lizard")
                    return $"CPU chose {cpuMove}. You Win!";
                else if (cpuMove == userMove)
                    return $"CPU chose {cpuMove}. Draw.";
                else
                    return $"CPU chose {cpuMove}. CPU Wins.";
            }
        }



public string PVP(string player1Move, string player2Move)
{
    if (player2Move == "rock")
    {
        if (player1Move == "paper" || player1Move == "spock")
            return $"Player 1 Wins!";
        else if (player2Move == player1Move)
            return $"Draw.";
        else
            return $"Player 2 Wins.";
    }
    else if (player2Move == "paper")
    {
        if (player1Move == "lizard" || player1Move == "scissors")
            return $"Player 1 Wins!";
        else if (player2Move == player1Move)
            return $"Draw.";
        else
            return $"Player 2 Wins.";
    }
    else if (player2Move == "scissors")
    {
        if (player1Move == "rock" || player1Move == "spock")
            return $"Player 1 Wins!";
        else if (player2Move == player1Move)
            return $"Draw.";
        else
            return $"Player 2 Wins.";
    }
    else if (player2Move == "lizard")
    {
        if (player1Move == "rock" || player1Move == "scissors")
            return $"Player 1 Wins!";
        else if (player2Move == player1Move)
            return $"Draw.";
        else
            return $"Player 2 Wins.";
    }
    else // spock
    {
        if (player1Move == "paper" || player1Move == "lizard")
            return $"Player 1 Wins!";
        else if (player2Move == player1Move)
            return $"Draw.";
        else
            return $"Player 2 Wins.";
    }
}
    }
}