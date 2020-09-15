using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 借還錢模擬小程式
{
    public partial class Form1 : Form
    {
        Person i, friend;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(friend, 1000);
            updateMoney();
        }

        private void repayButton_Click(object sender, EventArgs e)
        {
            i.repay(friend, 1000);
            updateMoney();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            i = new Person(myNameInput.Text, 0);
            friend = new Person(friendNameInput.Text, 200000);

            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            submitButton.Enabled = false;

            borrowButton.Text = "跟 " + friend.Name + " 借 1000 $";
            repayButton.Text = "還給 " + friend.Name + " 1000 $";

            borrowButton.Enabled = true;
            repayButton.Enabled = true;

            myNameLabel.Text = i.Name;
            friendNameLabel.Text = friend.Name;

        }

        private void updateMoney()
        {
            myMoneyLabel.Text = "" + i.Money;
            friendMoneyLabel.Text = "" + friend.Money;
        }
    }
}
