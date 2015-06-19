using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GameService
{
    public class Game : IGamePlayer, IGameManager
    {
        string StartGame(int n1, int n2) 
        { 
            return "Game started";
        }

        string EndGame() 
        {
            return "Game End!";
        }

        string SetPlay(int n1, int n2) 
        {
            return "You Win";
        }
    }
}
