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

namespace Attack_ATMB
{
    public partial class frmHuanLuyen : Form
    {
        public frmHuanLuyen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

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
            string str = ""; //khai bao chuoi
            int a1, b1, c1, d1, e1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1, x1, y1, z1, idem;
            a1 = b1 = c1 = d1 = e1 = f1 = g1 = h1 = i1 = j1 = k1 = l1 = m1 = n1 = o1 = p1 = q1 = r1 = s1 = t1 = u1 = v1 = w1 = x1 = y1 = z1 = 0;
            char[] arr1;
            int l2 = 0;
            l2 = string1.Length;
            arr1 = string1.ToCharArray(0, l2); // chuyen chuoi thanh mang ky tu.  

            char ch;
            for (int i = 0; i < l2; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) // kiem tra ky tu thuong  
                    Char.ToLower(ch); // chuyen doi chu thuong thanh chu hoa.  
                else
                    Char.ToLower(ch); // chuyen doi chu hoa thanh chu thuong.  
            }


            /* kiem tra tung ky tu trong chuoi*/
            idem = 0;
            while (idem < l2)
            {
                if (string1[idem] == 'a')
                {
                    a1++;
                }
                if (string1[idem] == 'b')
                {
                    b1++;
                }
                if (string1[idem] == 'c')
                {
                    c1++;
                }
                if (string1[idem] == 'd')
                {
                    d1++;
                }
                if (string1[idem] == 'e')
                {
                    e1++;
                }
                if (string1[idem] == 'f')
                {
                    f1++;
                }
                if (string1[idem] == 'g')
                {
                    g1++;
                }
                if (string1[idem] == 'h')
                {
                    h1++;
                }
                if (string1[idem] == 'i')
                {
                    i1++;
                }
                if (string1[idem] == 'j')
                {
                    j1++;
                }
                if (string1[idem] == 'k')
                {
                    k1++;
                }
                if (string1[idem] == 'l')
                {
                    l1++;
                }
                if (string1[idem] == 'm')
                {
                    m1++;
                }
                if (string1[idem] == 'n')
                {
                    n1++;
                }
                if (string1[idem] == 'o')
                {
                    o1++;
                }
                if (string1[idem] == 'p')
                {
                    p1++;
                }
                if (string1[idem] == 'q')
                {
                    q1++;
                }
                if (string1[idem] == 'r')
                {
                    r1++;
                }
                if (string1[idem] == 's')
                {
                    s1++;

                }
                if (string1[idem] == 't')
                {
                    t1++;

                }
                if (string1[idem] == 'u')
                {
                    u1++;

                }
                if (string1[idem] == 'v')
                {
                    v1++;

                }
                if (string1[idem] == 'w')
                {
                    w1++;

                }
                if (string1[idem] == 'x')
                {
                    x1++;

                }
                if (string1[idem] == 'y')
                {
                    y1++;

                }
                if (string1[idem] == 'z')
                {
                    z1++;

                }
                idem++;
            }
            float demtongsochu = 0;
            demtongsochu = a1 + b1 + c1 + d1 + e1 + f1 + g1 + h1 + i1 + j1 + k1 + l1 + m1 + n1 + o1 + p1 + q1 + r1 + s1 + t1 + u1 + v1 + w1 + x1 + y1 + z1;

            float a2, b2, c2, d2, e2, f2, g2, h2, i2, j2, k2, l3, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2, x2, y2, z2;
            a2 = a1 / demtongsochu;
            b2 = b1 / demtongsochu;
            c2 = c1 / demtongsochu;
            d2 = d1 / demtongsochu;
            e2 = e1 / demtongsochu;
            f2 = f1 / demtongsochu;
            g2 = g1 / demtongsochu;
            h2 = h1 / demtongsochu;
            i2 = i1 / demtongsochu;
            j2 = j1 / demtongsochu;
            k2 = k1 / demtongsochu;
            l3 = l1 / demtongsochu;
            m2 = m1 / demtongsochu;
            n2 = n1 / demtongsochu;
            o2 = o1 / demtongsochu;
            p2 = p1 / demtongsochu;
            q2 = q1 / demtongsochu;
            r2 = r1 / demtongsochu;
            s2 = s1 / demtongsochu;
            t2 = t1 / demtongsochu;
            u2 = u1 / demtongsochu;
            v2 = v1 / demtongsochu;
            w2 = w1 / demtongsochu;
            x2 = x1 / demtongsochu;
            y2 = y1 / demtongsochu;
            z2 = z1 / demtongsochu;
            //anh chon duong dan tuyet doi,ghi ra file

            FileStream myFile = new FileStream(@"./Learn-09/xuatthongke.txt", FileMode.Create);
            BinaryWriter brFile = new BinaryWriter(myFile);

            brFile.Write("chu a :" + a1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu b :" + b1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu c :" + c1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu d :" + d1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu e :" + e1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu f :" + f1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu g :" + g1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu h :" + h1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu i :" + i1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu j :" + j1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu k :" + k1);
            brFile.Write(Environment.NewLine);

            brFile.Write("chu l :" + l1);
            brFile.Write(Environment.NewLine);

            brFile.Write("chu m :" + m1);
            brFile.Write(Environment.NewLine);

            brFile.Write("chu n :" + n1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu 0 :" + o1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu p :" + p1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu q :" + q1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu r :" + r1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu x :" + x1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu t :" + t1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu u :" + u1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu w :" + w1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu x :" + x1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu y :" + y1);
            brFile.Write(Environment.NewLine);
            brFile.Write("chu z :" + z1);
            brFile.Write("tong so chu  :" + demtongsochu);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu a : " + a2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu b : " + b2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu c : " + c2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu d : " + d2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu e : " + e2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu f : " + f2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu g : " + g2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu h : " + h2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu i : " + i2);
            brFile.Write(Environment.NewLine);
            brFile.Write("tỉ lệ chữ j : " + j2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu k : " + k2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu l : " + l3);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu m : " + m2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu n : " + n2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu o : " + o2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu p : " + p2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu q : " + q2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu r : " + r2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu s : " + s2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu t : " + t2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu u : " + u2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu v : " + v2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu w : " + w2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu x : " + x2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu y : " + y2);
            brFile.Write(Environment.NewLine);
            brFile.Write("ty le chu z : " + z2);
            brFile.Close();
            myFile.Close();
        }
    }
}
