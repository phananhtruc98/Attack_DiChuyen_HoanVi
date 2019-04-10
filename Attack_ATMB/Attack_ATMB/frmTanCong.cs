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
            string stringz = @"abcdefghijklmnopqrstuvwxyz";
            int t0 = 0;
            string tr0;
           
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
            textBox2.Text = tr0;
            textBox3.Text = tr1;
            textBox4.Text = tr2;
            textBox5.Text = tr3;
            textBox6.Text = tr4;
            textBox7.Text = tr5;
            textBox8.Text = tr6;
            textBox9.Text = tr7;
            textBox10.Text = tr8;
            textBox11.Text = tr9;
            textBox12.Text = tr10;
            textBox13.Text = tr11;
            textBox14.Text = tr12;
            textBox15.Text = tr13;
            textBox16.Text = tr14;
            textBox17.Text = tr16;
            textBox18.Text = tr17;
            textBox19.Text = tr18;
            textBox20.Text = tr19;
            textBox21.Text = tr20;
            textBox22.Text = tr21;
            textBox23.Text = tr22;
            textBox24.Text = tr23;
            textBox25.Text = tr24;
            textBox26.Text = tr25;
            textBox27.Text = tr26;
        }
    }
}
