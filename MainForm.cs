using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
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
            this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings FormSerrings = new Settings();
            FormSerrings.Show();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutProgram FormAbout = new AboutProgram();
            FormAbout.Show();
        }

        private void остаткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Visible = true;
        }
    }
}
