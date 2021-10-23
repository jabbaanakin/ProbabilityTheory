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
    public partial class Form1 : Form
    {
        public Form1(int _count, List<string> _namesList, List<int> _countsList)
        {
            InitializeComponent();
            _typesCount = _count;
            _typesNamesList = _namesList;
            _typesCountList = _countsList;
            Generate();
        }

        int _typesCount;
        List<string> _typesNamesList = new List<string>();
        List<int> _typesCountList = new List<int>();
        List<TextBox> _textBoxesList = new List<TextBox>(); 
        int saveLocation = 35;

        private void Generate()
        {
            for(int i = 0; i < _typesCount; i++)
            {
                _textBoxesList.Add(new TextBox() { Name = _typesNamesList[i], Location = new Point(12, saveLocation) });
                this.Controls.Add(_textBoxesList[i]);
                this.Controls.Add(new Label() { Text = $"{_typesNamesList[i]} count:", Location = new Point(12, saveLocation - 20)});
                saveLocation += 65;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal cardsCount = 0;
            decimal chance = 1;

            foreach(var x in _typesCountList)
            {
                cardsCount += x;
            }

            resultListView.Items.Clear();

            try
            {
                for(int i = 0; i < _textBoxesList.Count; i++)
                {
                    if(_textBoxesList[i].Text != "")
                    {
                        int allTypeCardsCount = _typesCountList[i];
                        int countOfCurrentCards = int.Parse(_textBoxesList[i].Text);
                        for(int j = 0; j < countOfCurrentCards; j++)
                        {
                            chance *= ((allTypeCardsCount - j) / cardsCount);
                            cardsCount--;
                        }
                    }
                }
                resultListView.Items.Add(chance.ToString("P2"));
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
