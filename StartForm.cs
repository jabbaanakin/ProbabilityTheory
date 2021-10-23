using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cluedo
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        int cardTypesCount;
        int count = 1;
        List<string> cardTypesNames = new List<string>();
        List<int> _typesCountList = new List<int>();

        private void cardTypesCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                cardTypesCount = int.Parse(cardTypesCountTextBox.Text);
                cardTypeNameTextBox.Visible = true;
                nameOfCardTypeLabel.Visible = true;
                cardTypeNameButton.Visible = true;
                nameOfCardTypeLabel.Text = "Название 1-й масти:";
                cardTypesNames.Clear();
                _typesCountList.Clear();
            }
            catch { MessageBox.Show("Enter correct number"); }
        }

        private void cardTypeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                cardTypesNames.Add(cardTypeNameTextBox.Text);
                cardTypeNameTextBox.Clear();
                typeCountTextBox.Focus();
                typeCountTextBox.Visible = true;
                typeCountButton.Visible = true;
                typeCountTextBox.Focus();
            }
            catch { MessageBox.Show("Enter correct name"); }
        }

        private void typeCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                if (count > cardTypesCount)
                {
                    Form form = new Form1(cardTypesCount, cardTypesNames, _typesCountList);
                    form.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                    form.Show();
                    this.Hide();
                    cardTypeNameTextBox.Visible = false;
                    nameOfCardTypeLabel.Visible = false;
                    cardTypeNameButton.Visible = false;
                    nameOfCardTypeLabel.Text = $"Название {count}-й масти:";
                }
                _typesCountList.Add(int.Parse(typeCountTextBox.Text));
                typeCountTextBox.Clear();
                cardTypeNameTextBox.Focus();
                typeCountTextBox.Visible = false;
                typeCountButton.Visible = false;
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
