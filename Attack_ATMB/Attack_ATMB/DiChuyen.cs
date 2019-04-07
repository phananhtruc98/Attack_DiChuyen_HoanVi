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
        string s;
        string inputMahoa;
        string filenameinputMahoa;
        string filenameoutputMahoa;
        public DiChuyen()
        {

            InitializeComponent();
            s ="Dịch chuyển" + Environment.NewLine + "'aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()\'"
                + Environment.NewLine+ "3" + Environment.NewLine;
            txtOutputMaHoaFile.Text = s;

        }


        private void btnMaHoa_Click_1(object sender, EventArgs e)
        {
            int dichChuyen_Key = 3;
            string dichChuyen_Z = "'aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()\'";
            OutputText.Text = Ceasar.Encipher(InputText.Text, dichChuyen_Key, dichChuyen_Z);
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            int dichChuyen_Key = 3;
            string dichChuyen_Z = "'aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()\'";
            OutputText.Text = Ceasar.Decipher(InputText.Text, dichChuyen_Key, dichChuyen_Z);
        }

        private void btnChonTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathInputMaHoa.Text = openFileDialog1.FileName;
                filenameinputMahoa = System.IO.Path.GetFileName(@"" + txtPathInputMaHoa.Text + "");
            }

            inputMahoa = FileHelper.ReadFile(@"" + txtPathInputMaHoa.Text + "");
        }

        private void btnMaHoaFile_Click(object sender, EventArgs e)
        {
            if(txtPathInputMaHoa.Text != "")
            {
                string dichChuyen_Input = inputMahoa;
                string dichChuyen_Z = "'aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()\'";
                int dichChuyen_Key = 3;
                txtOutputMaHoaFile.Text = s + Ceasar.Encipher(dichChuyen_Input, dichChuyen_Key, dichChuyen_Z);
                string outputfile = Ceasar.Encipher(dichChuyen_Input, dichChuyen_Key, dichChuyen_Z);
                string[] outputlines = txtOutputMaHoaFile.Lines;
                string[] arrListStr = filenameinputMahoa.Split(new char[] { '_' });
                string dungluong = "";
                for (int i = 0; i <= arrListStr.Length; i++)
                {
                    if(i == 1)  dungluong = arrListStr[1]; 
                }

                switch (dungluong)
                {
                    case "1mb":
                        filenameoutputMahoa = "Enc_1mb_11.txt";
                        break;
                    case "500kb":
                        filenameoutputMahoa = "Enc_500kb_11.txt";
                        break;
                    case "100kb":
                        filenameoutputMahoa = "Enc_100kb_11.txt";
                        break;
                    case "10kb":
                        filenameoutputMahoa = "Enc_10kb_11.txt";
                        break;
                }
                //FileHelper.WriteFile(@"C:\Attack_DiChuyen_HoanVi\Attack_ATMB\Attack_ATMB\"+ filenameoutputMahoa + "", outputlines);
                txtOutputName.Text = System.IO.Path.GetFileName(@"C:\Attack_DiChuyen_HoanVi\Attack_ATMB\Attack_ATMB\" + filenameoutputMahoa + "");
            }
            else
            {
                MessageBox.Show("Chưa chọn file để mã hóa");
            }
        }

        private void btnGiaiMaFile_Click(object sender, EventArgs e)
        {
            string dichChuyen_Input = inputMahoa;
            string dichChuyen_Z = "'aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()\'";
            int dichChuyen_Key = 3;
            txtOutputMaHoaFile.Text = Ceasar.Encipher(dichChuyen_Input, dichChuyen_Key, dichChuyen_Z);

        }

        private void btnOpenFileEncrypt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Attack_DiChuyen_HoanVi\Attack_ATMB\Attack_ATMB\"+ filenameoutputMahoa + "");
        }

    }
}
