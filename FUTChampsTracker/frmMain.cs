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
        private AlexClass _alexClass;

        public frmMain()
        {
            InitializeComponent();
            _alexClass = new AlexClass();
        }

        public void btnAddGoal1_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer1);
        }

        public void btnAddAssist1_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer1);
        }

        public void btnAddGoal2_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer2);
        }

        public void btnAddAssist2_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer2);
        }

        public void btnAddGoal3_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer3);
        }

        public void btnAddAssist3_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer3);
        }

        public void btnAddGoal4_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer4);
        }

        public void btnAddAssist4_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer4);
        }

        public void btnAddGoal5_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer5);
        }

        public void btnAddAssist5_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer5);
        }

        public void btnAddGoal6_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer6);
        }

        public void btnAddAssist6_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer6);
        }

        public void btnAddGoal7_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer7);
        }

        public void btnAddAssist7_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer7);
        }

        public void btnAddGoal8_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer8);
        }

        public void btnAddAssist8_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer8);
        }

        public void btnAddGoal9_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer9);
        }

        public void btnAddAssist9_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer9);
        }

        public void btnAddGoal10_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer10);
        }

        public void btnAddAssist10_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer10);
        }

        public void btnAddGoal11_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer11);
        }

        public void btnAddAssist11_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer11);
        }

        public void btnAddGoal12_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer12);
        }

        public void btnAddAssist12_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer12);
        }

        public void btnAddGoal13_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer13);
        }

        public void btnAddAssist13_Click(object sender, EventArgs e)
        {
           _alexClass.AddAssist(txtAssistsPlayer13);
        }

        public void btnAddGoal14_Click(object sender, EventArgs e)
        {
           _alexClass.AddGoal(txtGoalsPlayer14);
        }

        public void btnAddAssist14_Click(object sender, EventArgs e)
        {
            _alexClass.AddAssist(txtAssistsPlayer14);
        }
    }
}
