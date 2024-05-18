using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_DB_PROJECT
{
    public partial class QueryReportDisplay : Form
    {
        public QueryReportDisplay(Action onCloseCallback)
        {
            InitializeComponent();
            this.onCloseCallback = onCloseCallback;
        }
        private Action onCloseCallback;
        public DataGridView ReportDataGridView
        {
            get { return dataGridView1; }
        }

        private void QueryReportDisplay_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
