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
    public partial class M_Register : UserControl
    {
        public M_Register(Action onCloseCallback)
        {
            InitializeComponent();
            this.onCloseCallback = onCloseCallback;
        }
        private Action onCloseCallback;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void M_Register_Load(object sender, EventArgs e)
        {

        }
    }
}
