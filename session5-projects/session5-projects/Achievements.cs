using System;
using System.Collections.Generic;
using System.Text;

namespace session5_projects
{
    class Achievements
    {
        Player player = new Player();
        void Start()
        {
            //I subscribed the method(OnPlayerDeath) to the delegate
            player.deathEvent += OnPlayerDeath;
        }
        public void OnPlayerDeath()
        {
            //Write something... save into database
            player.deathEvent -= OnPlayerDeath;
        }

    }
}
