using Attack_ATMB.MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attack_ATMB
{
    public partial class DiChuyen : Form
    {

        int dichChuyen_Key = 0;
        string dichChuyen_Z = "";
        string inputMahoa;
        string inputGiaima;
        string filenameinputMahoa;
        string filenameinputGiaima;
        string filenameoutputMahoa;
        string filenameoutputGiaima;
        string filenameoutputMahoaChallenge;
        string filenameoutputGiaimaChallenge;
        string outputMahoa;
        string outputGiaima;
        public DiChuyen()
        {

            InitializeComponent();
            txtZ.Text = dichChuyen_Z;

        }

        //abcdefghijklmnopqrstuvwxyz
        private void btnMaHoa_Click_1(object sender, EventArgs e)
        {
            if (txtK.Text != "" && txtZ.Text != "")
            {
                dichChuyen_Key = int.Parse(txtK.Text);
                dichChuyen_Z = txtZ.Text;
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin!!");
                return;
            }
            OutputText.Text = Ceasar.Encipher(InputText.Text, dichChuyen_Key, dichChuyen_Z);
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (txtK.Text != "" && txtZ.Text != "")
            {
                dichChuyen_Key = int.Parse(txtK.Text);
                dichChuyen_Z = txtZ.Text;
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin!!");
                return;
            }
            OutputText.Text = Ceasar.Decipher(InputText.Text, dichChuyen_Key, dichChuyen_Z);
        }

        private void btnChonTep_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathInputMaHoa.Text = openFileDialog1.FileName;
                filenameinputMahoa = System.IO.Path.GetFileName(@"" + txtPathInputMaHoa.Text + "");

            }
            else
            {
                MessageBox.Show("Chưa chọn tệp!!");
                return;
            }
            inputMahoa = FileHelper.ReadFile(@"" + txtPathInputMaHoa.Text + "");
        }

        private void btnMaHoaFile_Click(object sender, EventArgs e)
        {
            if (txtPathInputMaHoa.Text != "")
            {

                if (txtKeyMahoa.Text != "" && txtZMahoa.Text != "")
                {
                    dichChuyen_Key = int.Parse(txtKeyMahoa.Text);
                    dichChuyen_Z = txtZMahoa.Text;
                    string dichChuyen_Input = inputMahoa;
                    string dungluong = filenameinputMahoa.Split(new char[] { '_' })[1];
                    filenameoutputMahoa = "Enc_" + dungluong + "_11.txt";
                    filenameoutputMahoaChallenge = "Challenge_" + dungluong + "_11.txt";
                    outputMahoa = Ceasar.Encipher(dichChuyen_Input, dichChuyen_Key, dichChuyen_Z);
                    FileHelper.WriteFile(@"" + filenameoutputMahoa + "", "Di chuyển", dichChuyen_Z, dichChuyen_Key.ToString(), outputMahoa);
                    txtOutputName.Text = System.IO.Path.GetFileName(@"" + filenameoutputMahoa + "");
                    FileHelper.WriteFile(@"" + filenameoutputMahoaChallenge + "", "Di chuyển", dichChuyen_Z, outputMahoa);
                    txtOutputChallengeName.Text = System.IO.Path.GetFileName(@"" + filenameoutputMahoaChallenge + "");
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin!!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn file để mã hóa");
            }
        }



        private void btnOpenFileEncrypt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"" + filenameoutputMahoa + "");
        }

        private void btnOpenFileChallenge_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"" + filenameoutputMahoaChallenge + "");
        }

        private void btnChonTepGiaiMa_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathInputGiaiMa.Text = openFileDialog1.FileName;
                filenameinputGiaima = System.IO.Path.GetFileName(@"" + txtPathInputGiaiMa.Text + "");
            }
            else
            {
                MessageBox.Show("Chưa chọn tệp!!");
                return;
            }
            if (txtPathInputGiaiMa.Text.Contains("Enc"))
            {
                Tuple<string, string, string, string> readFile = FileHelper.ReadFileEnc(@"" + txtPathInputGiaiMa.Text + "");
                txtZGiaima.Text = readFile.Item2;
                dichChuyen_Z = txtZGiaima.Text;
                mnrKeyGiaiMa.Text = readFile.Item3;
                inputGiaima = readFile.Item4;
            }
            if (txtPathInputGiaiMa.Text.Contains("Challenge"))
            {
                Tuple<string, string, string> readFileChallenge = FileHelper.ReadFileChallenge(openFileDialog1.FileName);
                txtZGiaima.Text = readFileChallenge.Item2;
                dichChuyen_Z = txtZGiaima.Text;
                inputGiaima = readFileChallenge.Item3;
            }

        }

        private void btnGiaiMaFile_Click(object sender, EventArgs e)
        {
            if (txtPathInputGiaiMa.Text != "")
            {

                if (mnrKeyGiaiMa.Text != "" || txtZGiaima.Text != "")
                {
                    dichChuyen_Key = int.Parse(mnrKeyGiaiMa.Text);
                    string dichChuyen_Input = inputGiaima;
                    string dungluong = filenameinputGiaima.Split(new char[] { '_' })[1];
                    filenameoutputGiaima = "Decrypt_" + dungluong + "_11.txt";
                    filenameoutputGiaimaChallenge = "Decrypt_Challenge" + dungluong + "_11.txt";
                    OutputText.Text = Ceasar.Decipher(dichChuyen_Input, dichChuyen_Key, dichChuyen_Z);
                    outputGiaima = Ceasar.Decipher(dichChuyen_Input, dichChuyen_Key, dichChuyen_Z);
                    FileHelper.WriteFile(@"" + filenameoutputGiaima + "", "Di chuyển", dichChuyen_Z, dichChuyen_Key.ToString(), outputGiaima);
                    txtOutputGiaiMaName.Text = System.IO.Path.GetFileName(@"" + filenameoutputGiaima + "");
                    FileHelper.WriteFile(@"" + filenameoutputGiaimaChallenge + "", "Di chuyển", dichChuyen_Z, outputGiaima);
                    txtOutputGiaiMaChallengeName.Text = System.IO.Path.GetFileName(@"" + filenameoutputGiaimaChallenge + "");
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin!!!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn file để giải mã");
            }
        }

        private void btnOpenFileDecrypt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"" + filenameoutputGiaima + "");

        }

        private void btnOpenFileDecryptChallenge_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"" + filenameoutputGiaimaChallenge + "");

        }

        private void txtKeyMahoa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtKeyGiaiMa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
