using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class MatrixForm : Form
    {
        int M, N;
        public MatrixForm()
        {
            InitializeComponent();
        }

        private void buttonSetMN_Click(object sender, EventArgs e)
        {
            M = (int)numericUpDownM.Value;
            N = (int)numericUpDownN.Value;

            dataGridViewMatrix.RowCount = M;
            dataGridViewMatrix.ColumnCount = N;
        }
    }
}
