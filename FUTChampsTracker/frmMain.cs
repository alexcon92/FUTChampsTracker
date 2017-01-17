using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUTChampsTracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddGoal1_Click(object sender, EventArgs e)
        {
            int currentGoals = Convert.ToInt32(txtGoalsPlayer1.Text);
            txtGoalsPlayer1.Text = (currentGoals + 1).ToString();
        }

        private void btnAddAssist1_Click(object sender, EventArgs e)
        {
            int currentAssists = Convert.ToInt32(txtAssistsPlayer1.Text);
            txtAssistsPlayer1.Text = (currentAssists + 1).ToString();
        }

        private void btnAddGoal2_Click(object sender, EventArgs e)
        {
            int currentGoals = Convert.ToInt32(txtGoalsPlayer2.Text);
            txtGoalsPlayer2.Text = (currentGoals + 1).ToString();
        }

        private void btnAddAssist2_Click(object sender, EventArgs e)
        {
            int currentAssists = Convert.ToInt32(txtAssistsPlayer2.Text);
            txtAssistsPlayer2.Text = (currentAssists + 1).ToString();
        }

        private void btnAddGoal3_Click(object sender, EventArgs e)
        {
            int currentGoals = Convert.ToInt32(txtGoalsPlayer3.Text);
            txtGoalsPlayer3.Text = (currentGoals + 1).ToString();
        }

        private void btnAddAssist3_Click(object sender, EventArgs e)
        {
            int currentAssists = Convert.ToInt32(txtAssistsPlayer3.Text);
            txtAssistsPlayer3.Text = (currentAssists + 1).ToString();
        }

        private void btnAddGoal4_Click(object sender, EventArgs e)
        {
            int currentGoals = Convert.ToInt32(txtGoalsPlayer4.Text);
            txtGoalsPlayer4.Text = (currentGoals + 1).ToString();
        }

        private void btnAddAssist4_Click(object sender, EventArgs e)
        {
            int currentAssists = Convert.ToInt32(txtAssistsPlayer4.Text);
            txtAssistsPlayer4.Text = (currentAssists + 1).ToString();
        }

        private void btnAddGoal5_Click(object sender, EventArgs e)
        {
            int currentGoals = Convert.ToInt32(txtGoalsPlayer5.Text);
            txtGoalsPlayer5.Text = (currentGoals + 1).ToString();
        }

        private void btnAddAssist5_Click(object sender, EventArgs e)
        {
            int currentAssists = Convert.ToInt32(txtAssistsPlayer5.Text);
            txtAssistsPlayer5.Text = (currentAssists + 1).ToString();
        }
    }
}
