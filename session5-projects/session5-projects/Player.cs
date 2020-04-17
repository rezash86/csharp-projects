using System;
using System.Collections.Generic;
using System.Text;

namespace session5_projects
{
    class Player
    {
        //public delegate void DeathDelegate();
        //public event DeathDelegate deathEvent;
        public event Action deathEvent;

        Func<int, string, bool> myDelegate1;
        delegate bool myDelegate2(int a, int b);

        void Die()
        {
            //Achievements ach = new Achievements();
            //ach.OnPlayerDeath();

            //UserInterface userInterface = new UserInterface();
            //userInterface.OnPlayerDeath();

            if(deathEvent != null)
            {
                deathEvent();
            }
        }

        //Action and Func
        //Action can be used when we have delegate void return type, no parameters
        //Action<T>, Action<T1,T2> => delegate with void return tyoe, custome parameters

        //Func<T> => delegate with custome Return type , no parameters
        //Func<T1,T2> => delegate with custome Return type, custome parameters
    }
}
