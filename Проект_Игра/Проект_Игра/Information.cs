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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            labelDeveloper.Text = "Разработчик: Колмогорова В.Г";
            labelInfo.Text = "Все спрайты были взяты из";
            linkLabelSource.Text = "ДАННОГО ИСТОЧНИКА";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelSource.LinkVisited = false;
            System.Diagnostics.Process.Start("https://spritedatabase.net/game/1979");
        }
    }
}
