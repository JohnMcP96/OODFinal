using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Final
{
    public partial class UpdateChoiceForm : Form
    {
        public string Choice { get; private set; }

        public UpdateChoiceForm()
        {
            InitializeComponent();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Choice = "income";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            Choice = "expense";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
