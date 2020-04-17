using System;
using System.Collections.Generic;
using System.Text;

namespace session5_projects
{
    class UserInterface
    {
        Player player = new Player();
        void Start()
        {
            //I subscribed the method(OnPlayerDeath) to the delegate
            player.deathEvent += OnPlayerDeath;
        }
        public void OnPlayerDeath()
        {
            //show a message you are dead !!!
            player.deathEvent -= OnPlayerDeath;
        }

    }
}
