using Crawler.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MLSearchBot : Form
    {
        public MLSearchBot()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.ColumnIndex
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MlService crawler = new MlService();
            crawler.getCarro(txtSearchInput.Text);
            //crawler.GetCotacaoMoedas();
        }

        private void BtnAlerta_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearchInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
