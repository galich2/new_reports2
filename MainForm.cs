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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_D__new_database_Client_sqliteDataSet.products". При необходимости она может быть перемещена или удалена.
            //this.productsTableAdapter.Fill(this._D__new_database_Client_sqliteDataSet.products);

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
