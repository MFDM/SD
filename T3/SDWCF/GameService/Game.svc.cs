using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GameService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Game : IGamePlayer, IGameManager
    {
        private Board b;
        public void StartGame(int n1, int n2)
        {
            b = new Board(n1, n2);
        }

        public void EndGame()
        {
            b = null;
        }

        public string SetPlay(int n1, int n2)
        {
            String res = b._celsContainer[n1][n2].cellContent;
            if (res != "Treasure") 
                b._celsContainer[n1][n2].SetRandomContent();
            return res;
        }
    }
}
