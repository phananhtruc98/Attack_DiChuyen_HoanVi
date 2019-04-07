using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attack_ATMB.MyLibrary;

namespace Attack_ATMB
{
    public partial class HoanVi : Form
    {
        public HoanVi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBefore.Text = FileHelper.ReadFile(openFileDialog1.FileName);
            }


        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (rdbMaHoa.Checked) txtAfter.Text = MyLibrary.TranspositionCipher.Encipher(txtBefore.Text, txtK.Text, txtZ.Text);
            if (rdbGiaiMa.Checked) txtAfter.Text = MyLibrary.TranspositionCipher.Decipher(txtBefore.Text, txtK.Text, txtZ.Text);
        }

        private void btnFileExecute_Click(object sender, EventArgs e)
        {
            if(clbTypeOutput.GetItemCheckState(0) == CheckState.Checked)
            {
                FileHelper.WriteFile(Application.StartupPath+@"\Decrypt_s_MaNhom.txt","Hoán vị",txtZ.Text,txtK.Text,txtAfter.Text);
            }
            if(clbTypeOutput.GetItemCheckState(1) == CheckState.Checked)
            {
                FileHelper.WriteFile(Application.StartupPath+@"\Decrypt_Challenge_s_MaNhom.txt","Hoán vị",txtZ.Text,txtAfter.Text);
            }
        }
    }
}
