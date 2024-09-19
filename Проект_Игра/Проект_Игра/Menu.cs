using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_Игра
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            DialogResult exit_message = MessageBox.Show("Хотите выйти?",
              "EXIT",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1);
            if (exit_message == DialogResult.Yes)
                this.Close();
        }

        private void Button_START_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
        }
    }
}
