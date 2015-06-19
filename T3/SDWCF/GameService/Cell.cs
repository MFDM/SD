using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService
{


    public class Cell
    {
        private string[] cellContentVals = {"Death","Life","Zero"};

        public string cellContent { get; set; }

        public Cell()
        {
            SetRandomContent();
        }

        public void SetRandomContent()
        {
            string nextContent;
            Random random = new Random();

            nextContent = (string)cellContentVals.GetValue(random.Next(cellContentVals.Length));

            cellContent = nextContent;
        }

        public void SetTreasureContent()
        {
            cellContent = "Treasure";
        }
    }
}