using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using MaHoaDES.DoiTuong;

namespace AOC.ThuVien
{
    class DocFileTxt
    {
        public static ChuoiNhiPhan FileReadToBinary(string filename)
        {
            ChuoiNhiPhan chuoi;
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(0);
            byte[] fileBytes = File.ReadAllBytes(filename);
            //đọc dữ liệu của file và chuyển về thành 1 mảng byte
            foreach (byte b in fileBytes)
            {
                chuoi = ChuoiNhiPhan.ChuyenSoSangNhiPhan(b, 8);
                KQ = KQ.Cong(chuoi);
            }
            return KQ;
        }

        public static void WriteBinaryToFile(string filename, ChuoiNhiPhan chuoiVao)
        {
            byte[] MangByte = new byte[chuoiVao.MangNhiPhan.Length / 8];
            for (int i = 0; i < chuoiVao.MangNhiPhan.Length / 8; i++)
            {
                MangByte[i] = (byte)ChuoiNhiPhan.ChuyenMangSangByte(chuoiVao.MangNhiPhan, i * 8, i * 8 + 8);
            }
            File.WriteAllBytes(filename, MangByte);
        }
    }
}
