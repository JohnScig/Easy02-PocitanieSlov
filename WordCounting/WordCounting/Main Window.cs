using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CountWords_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> CountedWords = new Dictionary<string, int>();
            CountedWords = WordCount.CountWords(tBox_TextToCount.Text);
            dataGridView_SortCount.Rows.Clear();

            foreach (string word in CountedWords.Keys)
            {
                dataGridView_SortCount.Rows.Add(word, CountedWords[word]);
            }
            dataGridView_SortCount.Sort(dataGridView_SortCount.Columns[1], ListSortDirection.Descending);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            dataGridView_SortCount.Rows.Clear();
            WordCount.ClearDictionary();
        }
    }
}
