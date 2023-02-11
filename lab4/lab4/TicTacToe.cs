using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class TicTacToe
    {
        bool toogleValue = true;
        String userOne = "O";
        String userTwo = "X";
        
        public void setToggleValue(bool t)
        {
            toogleValue = t;
        }
        public bool getToogleValue()
        {
            return toogleValue;
        }
        public void setUserOne(String user)
        {
            userOne = user;
        }
        public String getUserOne()
        {
            return userOne;
        }
        public String getUserTwo()
        {
            return userTwo;
        }
        public void setUserTwo(String user)
        {
            userTwo = user;
        }
       


    }
}
