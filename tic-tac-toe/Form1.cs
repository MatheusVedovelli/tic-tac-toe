using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        private bool turn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Winner()
        {
            bool win = false;

            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
                win = true;
            if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
                win = true;
            if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
                win = true;

            if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
                win = true;
            if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
                win = true;
            if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
                win = true;

            if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
                win = true;
            if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
                win = true;

            if (win)
            {
                MessageBox.Show(string.Format("[{0}] é o vencedor!", turn ? "O" : "X"));
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turn = false;
            }
            else
                turn = !turn;
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "")
            {
                btn.Text = turn ? "O" : "X";
                Winner();
            }
            else MessageBox.Show("Escolha outro campo.");
        }
    }
}
