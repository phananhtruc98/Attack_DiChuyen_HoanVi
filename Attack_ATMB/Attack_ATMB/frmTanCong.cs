using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attack_ATMB.MyLibrary;
namespace Attack_ATMB
{
    public partial class frmTanCong : Form
    {
        public frmTanCong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ka = textBox1.Text;
            String string1 = "";
            try
            {
                // tao instance cua StreamReader de doc mot file.
                // lenh using cung duoc su dung de dong StreamReader.
                using (StreamReader sr = new StreamReader(ka))
                {
                    string line;

                    // doc va hien thi cac dong trong file cho toi
                    // khi tien toi cuoi file. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        string1 = string1 + line;
                        Console.WriteLine(line);
                    }
                }

                Console.ReadKey();
            }
            catch (Exception g)
            {
                // thong bao loi.
                Console.WriteLine("Khong the doc du lieu tu file da cho: ");
                Console.WriteLine(g.Message);
            }
            //sao chep 
            string stringz = @"aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()\.";

            string tr0;
            int t0 = 0;
            tr0 = Ceasar.Decipher(string1, t0, stringz);
            string tr1 = "";
            tr1 = Ceasar.Decipher(string1, 1, stringz);
            string tr2 = "";
            tr2 = Ceasar.Decipher(string1, 2, stringz);
            string tr3 = "";
            tr3 = Ceasar.Decipher(string1, 3, stringz);
            string tr4 = "";
            tr4 = Ceasar.Decipher(string1, 4, stringz);

            string tr5 = "";
            tr5 = Ceasar.Decipher(string1, 5, stringz);
            string tr6 = "";
            tr6 = Ceasar.Decipher(string1, 6, stringz);
            string tr7 = "";
            tr7 = Ceasar.Decipher(string1, 7, stringz);
            string tr8 = "";
            tr8 = Ceasar.Decipher(string1, 8, stringz);
            string tr9 = "";
            tr9 = Ceasar.Decipher(string1, 9, stringz);
            string tr10 = "";
            tr10 = Ceasar.Decipher(string1, 10, stringz);
            string tr11 = "";
            tr11 = Ceasar.Decipher(string1, 11, stringz);
            string tr12 = "";
            tr12 = Ceasar.Decipher(string1, 12, stringz);
            string tr13 = "";
            tr13 = Ceasar.Decipher(string1, 13, stringz);
            string tr14 = "";
            tr14 = Ceasar.Decipher(string1, 14, stringz);
            string tr15 = "";
            tr15 = Ceasar.Decipher(string1, 15, stringz);
            string tr16 = "";
            tr16 = Ceasar.Decipher(string1, 16, stringz);
            string tr17 = "";
            tr17 = Ceasar.Decipher(string1, 17, stringz);
            string tr18 = "";
            tr18 = Ceasar.Decipher(string1, 18, stringz);
            string tr19 = "";
            tr19 = Ceasar.Decipher(string1, 19, stringz);
            string tr20 = "";
            tr20 = Ceasar.Decipher(string1, 20, stringz);
            string tr21 = "";
            tr21 = Ceasar.Decipher(string1, 21, stringz);
            string tr22 = "";
            tr22 = Ceasar.Decipher(string1, 22, stringz);
            string tr23 = "";
            tr23 = Ceasar.Decipher(string1, 23, stringz);
            string tr24 = "";
            tr24 = Ceasar.Decipher(string1, 24, stringz);
            string tr25 = "";
            tr25 = Ceasar.Decipher(string1, 25, stringz);
            string tr26 = "";
            tr26 = Ceasar.Decipher(string1, 26, stringz);
            listBox1.Text = tr0 + tr1 + tr2 + tr3 + tr4 + tr5 + tr6 + tr7 + tr8 + tr9 + tr10 + tr11 + tr12 + tr13 + tr14 + tr15 + tr16 + tr17 + tr18 + tr19 + tr20 + tr21 + tr22 + tr23 + tr24 + tr25 + tr26;
        }
    }
}
