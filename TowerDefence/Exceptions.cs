using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    class TowerDefenceException : Exception
    {
        public TowerDefenceException()
        {

        }
        public TowerDefenceException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TowerDefenceException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
