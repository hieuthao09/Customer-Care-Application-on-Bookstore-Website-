using ChamSocKhachHang.DAL;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocKhachHang.BLL
{
    public class NhanVienBLL
    {
        public string TenDangNhap {get; set;}
        public string SDT {get; set;}
        public string Gioitinh {get; set;}
        public string NgaySinh {get; set;}
        public string DiaChi {get; set;}
        public string MaNV {get; set;}
        public string HoTen {get; set;}
        public string MatKhau { get; set; }

        public NhanVienBLL(string tenDangNhap, string sDT, string gioitinh, string ngaySinh, string diaChi, string maNV, string hoTen, string matKhau)
        {
            TenDangNhap = tenDangNhap;
            SDT = sDT;
            Gioitinh = gioitinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            MaNV = maNV;
            HoTen = hoTen;
            MatKhau = matKhau;
        }

        public NhanVienBLL()
        {
        }


        public List<NhanVienBLL> getListNhanVien()
        {
            List<NhanVienBLL> l = new List<NhanVienBLL>();
            var results = Neo4jConfig.QueryCypher("MATCH (n:NhanVien) RETURN n");

            foreach (IRecord res in results)
            {
                var node = res["n"].As<INode>();

                NhanVienBLL nv = new NhanVienBLL(
                    node["TenDangNhap"].ToString(),
                    node["SDT"].ToString(),
                    node["Gioitinh"].ToString(),
                    node["NgaySinh"].ToString(),
                    node["DiaChi"].ToString(),
                    node["MaNV"].ToString(),
                    node["HoTen"].ToString(),
                    node["MatKhau"].ToString()
                );

                //Console.WriteLine(kh);
                l.Add(nv);
            }
            return l;
        }

        private static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        public static NhanVienBLL login(string user, string pass)
        {
            NhanVienBLL nv = null;
            pass = Hash(pass);
            string q = string.Format("match (n:NhanVien) WHERE n.TenDangNhap='{0}' and n.MatKhau='{1}' return n",user,pass);

            IRecord temp = Neo4jConfig.QueryCypher(q).SingleOrDefault();
            if (temp != null)
            {
                var node = temp["n"].As<INode>();

                nv = new NhanVienBLL(
                    node["TenDangNhap"].ToString(),
                    node["SDT"].ToString(),
                    node["Gioitinh"].ToString(),
                    node["NgaySinh"].ToString(),
                    node["DiaChi"].ToString(),
                    node["MaNV"].ToString(),
                    node["HoTen"].ToString(),
                    node["MatKhau"].ToString()
                );
            }
            return nv;
        }
    }
}
