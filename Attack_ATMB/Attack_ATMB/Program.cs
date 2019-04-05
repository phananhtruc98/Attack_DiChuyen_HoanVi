using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attack_ATMB.MyLibrary;

namespace Attack_ATMB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("Mở file Program.cs để xem cách sử dụng Thuật mã/giải. Nhớ Debug");
            string dichChuyen_Input = "Hello mấy em";
            string dichChuyen_Z = "'aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()\'";
            int dichChuyen_Key = 3;
            string dichChuyen_DaMaHoa = Ceasar.Encipher(dichChuyen_Input, dichChuyen_Key, dichChuyen_Z);
            string dichChuyen_GiaiMaHoa = Ceasar.Decipher(dichChuyen_DaMaHoa, dichChuyen_Key, dichChuyen_Z);

            string hoanVi_Input = "Hello mấy em";
            string hoanVi_Z = "em"; //z: nhung ki tu can phai ma hoa
            string hoanVi_Key = "me"; // đã hoán vị
            string hoanVi_DaMaHoa = TranspositionCipher.Encipher(hoanVi_Input, hoanVi_Key, hoanVi_Z);
            string hoanVi_GiaiMaHoa = TranspositionCipher.Decipher(hoanVi_DaMaHoa, hoanVi_Key, hoanVi_Z);
            Application.Run(new Form1());

        }
    }
}
