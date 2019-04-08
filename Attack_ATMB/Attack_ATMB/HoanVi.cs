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
        private static string _size = "0";
        private static string _maNhom = "11";
        private static string _maNhomChallenge = "0";
        private readonly string message = "Đã xuất file '{0}'";
        private readonly string _outEncrypt = "Enc_{0}_{1}.txt";
        private readonly string _outEncryptChallenge = "Challenge_{0}_{1}.txt";
        private readonly string _outDecrypt = "Decrypt_{0}_{1}.txt";
        private readonly string _outDecryptChallenge = "Decrypt_Challenge_{0}_{1}_{2}.txt";
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
                _size = openFileDialog1.SafeFileName.Split('_')[1];
                if (rdbInput.Checked)
                {
                    txtBefore.Text = FileHelper.ReadFile(openFileDialog1.FileName);
                }
                if (rdbNhap.Checked)
                {
                    var stringFromFile = FileHelper.ReadFile(openFileDialog1.FileName)
                        .Split(new[] {Environment.NewLine}, StringSplitOptions.None);
                    txtZ.Text = stringFromFile[1];
                    txtK.Text = stringFromFile[2];
                    txtBefore.Text = string.Join(Environment.NewLine, stringFromFile.Skip(3));
                }

                if (rdbNhapChallenge.Checked)
                {
                    _maNhomChallenge = openFileDialog1.SafeFileName.Split('_')[2];
                }

            }


        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (rdbMaHoa.Checked) txtAfter.Text = MyLibrary.TranspositionCipher.Encipher(txtBefore.Text, txtK.Text, txtZ.Text);
            if (rdbGiaiMa.Checked) txtAfter.Text = MyLibrary.TranspositionCipher.Decipher(txtBefore.Text, txtZ.Text, txtK.Text);
        }

        private void btnFileExecute_Click(object sender, EventArgs e)
        {

            try
            {
                if (rdbMaHoa.Checked)
                {
                    if (clbTypeOutput.GetItemCheckState(0) == CheckState.Checked)
                    {
                        FileHelper.WriteFile(Application.StartupPath + $@"\{String.Format(_outEncrypt, _size, _maNhom)}", "Hoán vị", txtZ.Text,
                            txtK.Text, txtAfter.Text);
                        MessageBox.Show(String.Format(message, String.Format(_outEncrypt, _size, _maNhom)));
                    }

                    if (clbTypeOutput.GetItemCheckState(1) == CheckState.Checked)
                    {
                        FileHelper.WriteFile(Application.StartupPath + $@"\{String.Format(_outEncryptChallenge, _size, _maNhom)}", "Hoán vị",
                            txtZ.Text, txtAfter.Text);
                        MessageBox.Show(String.Format(message, String.Format(_outEncryptChallenge, _size, _maNhom)));
                    }
                }
                else
                {
                    if (clbTypeOutput.GetItemCheckState(0) == CheckState.Checked)
                    {
                        FileHelper.WriteFile(Application.StartupPath + $@"\{String.Format(_outDecrypt, _size, _maNhom)}", "Hoán vị", txtZ.Text,
                            txtK.Text, txtAfter.Text);
                        MessageBox.Show(String.Format(message, String.Format(_outDecrypt, _size, _maNhom)));
                    }

                    if (clbTypeOutput.GetItemCheckState(1) == CheckState.Checked)
                    {
                        FileHelper.WriteFile(Application.StartupPath + $@"\{String.Format(_outDecryptChallenge, _size, _maNhomChallenge, _maNhom)}", "Hoán vị",
                            txtZ.Text, txtAfter.Text);
                        MessageBox.Show(String.Format(message, String.Format(_outDecryptChallenge, _size, _maNhomChallenge, _maNhom)));
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rdbNhap_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           ClearTextBoxes(this.Controls);

        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
    }
}
