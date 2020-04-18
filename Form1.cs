using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattleApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            btn_Move1.Text = "Fighting";
            btn_Move2.Text = "Ghost";
        }

        private void btn_Move1_Click(object sender, EventArgs e)
        {
            string[] normAtkGood = new string[0];
            string[] normAtkBad = new string[1] { "rock" };
            string[] normDefGood = new string[0];
            string[] normDefBad = new string[1] { "fighting" };
            string[] normDefImmune = new string[1] { "ghost" };
            Type normal = new Type("normal", normAtkGood, normAtkBad, normDefGood, normDefBad, normDefImmune);

            int result = normal.MatchupCheck("fighting");

            if(result == 2)
            {
                MessageBox.Show("You chose the correct move!");
            }


        }

        private void btn_Move2_Click(object sender, EventArgs e)
        {
            string[] normAtkGood = new string[0];
            string[] normAtkBad = new string[1] { "rock" };
            string[] normDefGood = new string[0];
            string[] normDefBad = new string[1] { "fighting" };
            string[] normDefImmune = new string[1] { "ghost" };
            Type normal = new Type("normal", normAtkGood, normAtkBad, normDefGood, normDefBad, normDefImmune);

            int result = normal.MatchupCheck("ghost");

            if (result == 0)
            {
                MessageBox.Show("You chose the worst move!");
            }
        }

        private void btn_Move3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Move4_Click(object sender, EventArgs e)
        {

        }
    }
}
