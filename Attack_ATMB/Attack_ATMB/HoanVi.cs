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
                if (rdbEnc.Checked)
                {
                    Tuple<string, string, string, string> readFile = FileHelper.ReadFileEnc(openFileDialog1.FileName);
                    txtZ.Text = readFile.Item2;
                    txtK.Text = readFile.Item3;
                    txtBefore.Text = readFile.Item4;
                }

                if (rdbChallenge.Checked)
                {
                    Tuple<string, string, string> readFile = FileHelper.ReadFileChallenge(openFileDialog1.FileName);
                    txtZ.Text = readFile.Item2;
                    txtBefore.Text = readFile.Item3;
                    permute(txtZ.Text, 0, txtZ.Text.Length - 1);
                    txtChallengeK.Text = listPermute[current];
                    GetChallengeResult();
                }

            }


        }

        private static int current = 0;
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

                    FileHelper.WriteFile(Application.StartupPath + $@"\{String.Format(_outEncrypt, _size, _maNhom)}", "Hoán vị", txtZ.Text,
                        txtK.Text, txtAfter.Text);
                    MessageBox.Show(String.Format(message, String.Format(_outEncrypt, _size, _maNhom)));
                    FileHelper.WriteFile(Application.StartupPath + $@"\{String.Format(_outEncryptChallenge, _size, _maNhom)}", "Hoán vị",
                        txtZ.Text, txtAfter.Text);
                    MessageBox.Show(String.Format(message, String.Format(_outEncryptChallenge, _size, _maNhom)));

                }

                //if (clbTypeOutput.GetItemCheckState(0) == CheckState.Checked)
                if (rdbEnc.Checked)
                {
                    FileHelper.WriteFile(Application.StartupPath + $@"\{String.Format(_outDecrypt, _size, _maNhom)}", "Hoán vị", txtZ.Text,
                        txtK.Text, txtAfter.Text);
                    MessageBox.Show(String.Format(message, String.Format(_outDecrypt, _size, _maNhom)));
                }

                //if (clbTypeOutput.GetItemCheckState(1) == CheckState.Checked)
                if (rdbChallenge.Checked)
                {
                    FileHelper.WriteFile(Application.StartupPath + $@"\{String.Format(_outDecryptChallenge, _size, _maNhomChallenge, _maNhom)}", "Hoán vị",
                        txtZ.Text, txtAfter.Text);
                    MessageBox.Show(String.Format(message, String.Format(_outDecryptChallenge, _size, _maNhomChallenge, _maNhom)));
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
            WinformHelper.ClearTextBoxes(this.Controls);

        }

        private static List<string> listPermute = new List<string>();
        private static void permute(String str, int l, int r)
        {
            if (l == r)
                listPermute.Add(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        public static String swap(String a,
            int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            current--;
            if (current < 0) current = listPermute.Count - 1;
            GetChallengeResult();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            if (current > listPermute.Count - 1) current = 0;
            GetChallengeResult();
        }

        private void GetChallengeResult()
        {
            txtChallengeK.Text = listPermute[current];
            txtChallenge.Text = MyLibrary.TranspositionCipher.Decipher(txtBefore.Text, txtZ.Text, listPermute[current]);
        }
        private void GetChallengeResultK()
        {

            txtChallenge.Text = MyLibrary.TranspositionCipher.Decipher(txtBefore.Text, txtZ.Text, txtChallengeK.Text);
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            current = new Random().Next(listPermute.Count);
            GetChallengeResult();
        }

        private void btnChallengeKSelect_Click(object sender, EventArgs e)
        {
            GetChallengeResultK();
        }


       
    }
}
