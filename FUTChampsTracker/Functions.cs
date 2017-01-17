using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormSerialisation;

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

        public void SaveGame(Form form)
        {          
            SaveFileDialog saveWeekend = new SaveFileDialog();

            saveWeekend.Filter = "XML files (*.XML)|*.XML";

            if (saveWeekend.ShowDialog() == DialogResult.OK)
            {
                FormSerialisor.Serialise(form, saveWeekend.FileName + ".xml");
            }
        }

        public void LoadWeekend(Form form)
        {      
            OpenFileDialog findWeekend = new OpenFileDialog();

            findWeekend.Filter = "XML files (*.XML)|*.XML";

            if (findWeekend.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((findWeekend.OpenFile()) != null)
                    {
                            FormSerialisor.Deserialise(form, findWeekend.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk, are you sure this is a FUTChamps Tracker Record? Original error: " + ex.Message);
                }
            }
        }
    }
}
