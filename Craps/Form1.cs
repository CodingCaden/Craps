using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class Form1 : Form
    {
        #region Declarations
        int Dice1roll = new int();
        int Dice2roll = new int();
        int sDice1roll = new int();
        int sDice2roll = new int();
        int Ltotal;
        int Ftotal;
        bool isrollingset2 = false;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_rolldice_Click(object sender, EventArgs e)
        {
            dice1box.Visible = true;
            dice2box.Visible = true;

            if (isrollingset2 == false)
            {
                Console.WriteLine("Rolling set 1");
                RollDice();
            }else if(isrollingset2 == true)
            {
                Console.WriteLine("Rolling set 2");
                RollDiceSet2();
            }

            if (Ftotal == 7 || Ftotal == 11 )
            {
                MessageBox.Show("You Win!");
                playbtn.Visible = true;
                btn_rolldice.Visible = false;
            }
            else if (Ftotal == 2 || Ftotal == 3 || Ftotal == 12)
            {
                MessageBox.Show("You Loose!");
                playbtn.Visible = true;
                btn_rolldice.Visible = false;
            }

            if(Ftotal == 4)
            {
                isrollingset2 = true;

                if(Ltotal == 4)
                {
                    MessageBox.Show("You Win!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
                else if(Ltotal == 7)
                {
                    MessageBox.Show("You Loose!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
            }
            if (Ftotal == 5)
            {
                isrollingset2 = true;
                if (Ltotal == 5)
                {
                    MessageBox.Show("You Win!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
                else if (Ltotal == 7)
                {
                    MessageBox.Show("You Loose!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
            }
            if (Ftotal == 6)
            {
                isrollingset2 = true;
                if (Ltotal == 6)
                {
                    MessageBox.Show("You Win!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
                else if (Ltotal == 7)
                {
                    MessageBox.Show("You Loose!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
            }
            if (Ftotal == 8)
            {
                isrollingset2 = true;
                if (Ltotal == 8)
                {
                    MessageBox.Show("You Win!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
                else if (Ltotal == 7)
                {
                    MessageBox.Show("You Loose!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
            }
            if (Ftotal == 9)
            {
                isrollingset2 = true;
                if (Ltotal == 9)
                {
                    MessageBox.Show("You Win!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
                else if (Ltotal == 7)
                {
                    MessageBox.Show("You Loose!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
            }
            if (Ftotal == 10)
            {
                isrollingset2 = true;
                if (Ltotal == 10)
                {
                    MessageBox.Show("You Win!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
                else if (Ltotal == 7)
                {
                    MessageBox.Show("You Loose!");
                    playbtn.Visible = true;
                    btn_rolldice.Visible = false;
                }
            }

        }

        private void RollDice()
        {
            Random r = new Random();


            Dice1roll = r.Next(1, 7);

            

            if (Dice1roll == 1)
                dice1box.Image = dice1.Image;
            else if (Dice1roll == 2)
                dice1box.Image = dice2.Image;
            else if (Dice1roll == 3)
                dice1box.Image = dice3.Image;
            else if (Dice1roll == 4)
                dice1box.Image = dice4.Image;
            else if (Dice1roll == 5)
                dice1box.Image = dice5.Image;
            else if (Dice1roll == 6)
                dice1box.Image = dice6.Image;

            Dice2roll = r.Next(1, 7);

            if (Dice2roll == 1)
                dice2box.Image = dice1.Image;
            else if (Dice2roll == 2)
                dice2box.Image = dice2.Image;
            else if (Dice2roll == 3)
                dice2box.Image = dice3.Image;
            else if (Dice2roll == 4)
                dice2box.Image = dice4.Image;
            else if (Dice2roll == 5)
                dice2box.Image = dice5.Image;
            else if (Dice2roll == 6)
                dice2box.Image = dice6.Image;

            Ftotal = Dice1roll + Dice2roll;

        }
        private void RollDiceSet2()
        {
            Random r = new Random();


            Dice1roll = r.Next(1, 7);



            if (Dice1roll == 1)
                dice1box.Image = dice1.Image;
            else if (Dice1roll == 2)
                dice1box.Image = dice2.Image;
            else if (Dice1roll == 3)
                dice1box.Image = dice3.Image;
            else if (Dice1roll == 4)
                dice1box.Image = dice4.Image;
            else if (Dice1roll == 5)
                dice1box.Image = dice5.Image;
            else if (Dice1roll == 6)
                dice1box.Image = dice6.Image;

            Dice2roll = r.Next(1, 7);

            if (Dice2roll == 1)
                dice2box.Image = dice1.Image;
            else if (Dice2roll == 2)
                dice2box.Image = dice2.Image;
            else if (Dice2roll == 3)
                dice2box.Image = dice3.Image;
            else if (Dice2roll == 4)
                dice2box.Image = dice4.Image;
            else if (Dice2roll == 5)
                dice2box.Image = dice5.Image;
            else if (Dice2roll == 6)
                dice2box.Image = dice6.Image;

            Ltotal = Dice1roll + Dice2roll;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            dice1box.Image = null;
            dice2box.Image = null;
            btn_rolldice.Visible = true;
            playbtn.Visible = false;
            isrollingset2 = false;
            Ftotal = 0;
            Ltotal = 0;
        }
    }
}
