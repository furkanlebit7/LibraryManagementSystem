using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagement
{
    public partial class FrmPenalty : Form
    {
        public FrmPenalty()
        {
            InitializeComponent();
        }
        DateTime thisDay = DateTime.Today.AddDays(5);
        private void FrmPenalty_Load(object sender, EventArgs e)
        {
            DateTime start = new DateTime(2010, 6, 14);
            label1.Text = start.ToString();
        }
    }
}
