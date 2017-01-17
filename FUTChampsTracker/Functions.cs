using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUTChampsTracker
{
    public class AlexClass
    {
        public void AddGoal(TextBox player)
        {
            int currentGoals = Convert.ToInt32(player.Text);
            string newGoals = (currentGoals + 1).ToString();
            player.Text = newGoals;
            return;
        }

        public void AddAssist(TextBox player)
        {
            int currentAssists = Convert.ToInt32(player.Text);
            string newAssists = (currentAssists + 1).ToString();
            player.Text = newAssists;
            return;
        }
    }
}
