using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiseOfEmpires
{
    public class LandTile : Tile
    {
        public event EventHandler OnAttack;
        public event EventHandler OnOccopied;

        public bool IsInPossession
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool IsOccopied
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Player InPossesionBy
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}