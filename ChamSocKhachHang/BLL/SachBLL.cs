using ChamSocKhachHang.DAL;
using Neo4j.Driver;
using System.Collections.Generic;

namespace ChamSocKhachHang.BLL
{
    public class SachBLL
    {
        public string MaSach {get; set;}
        public string TenSach {get; set;}
        public List<string> TheLoai {get; set;}
        public string HinhAnh {get; set;}
        public string MoTa {get; set;}
        public long Gia { get; set; }

        public SachBLL() { }

        public SachBLL(string maSach, string tenSach, List<string> theLoai, string hinhAnh, string moTa, long gia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TheLoai = theLoai;
            HinhAnh = hinhAnh;
            MoTa = moTa;
            Gia = gia;
        }

        public List<object> listSachDuocMuaNhieu(string nam, string limit)
        {
            List<object> l = new List<object>();
            string q = string.Format("match (:KhachHang)-[r:MUA]-(s:Sach) where r.NgayMua.year={0} return s.MaSach as maSach, count(*) as soluongsach ORDER BY soluongsach DESC limit {1}", nam,limit);
            var results = Neo4jConfig.QueryCypher(q);

            foreach (IRecord res in results)
            {
                string maSach = res["maSach"].As<string>();
                string soLuongSach = res["soluongsach"].As<string>();

                //Console.WriteLine(kh);
                l.Add(new { maSach, soLuongSach });
            }
            return l;
        }

        public List<object> listSachDuocMuaIt(string nam, string limit)
        {
            List<object> l = new List<object>();
            string q = string.Format("match (:KhachHang)-[r:MUA]-(s:Sach) where r.NgayMua.year={0} return s.MaSach as maSach, count(*) as soluongsach ORDER BY soluongsach ASC limit {1}", nam, limit);
            var results = Neo4jConfig.QueryCypher(q);

            foreach (IRecord res in results)
            {
                string maSach = res["maSach"].As<string>();
                string soLuongSach = res["soluongsach"].As<string>();

                //Console.WriteLine(kh);
                l.Add(new { maSach, soLuongSach });
            }
            return l;
        }

        public List<object> listTheLoaiDuocMuaIt(string nam, string limit)
        {
            List<object> l = new List<object>();
            string q = string.Format("match (:KhachHang)-[r:MUA]-(s:Sach) where r.NgayMua.year={0} with s.TheLoai as mang unwind mang  as tl  return tl, count(*) as soluongtl ORDER BY soluongtl ASC limit {1}", nam, limit);
            var results = Neo4jConfig.QueryCypher(q);

            foreach (IRecord res in results)
            {
                string tenTL = res["tl"].As<string>();
                string soluongTL = res["soluongtl"].As<string>();

                //Console.WriteLine(kh);
                l.Add(new { tenTL, soluongTL });
            }
            return l;
        }

        public List<object> listTheLoaiDuocMuaNhieu(string nam, string limit)
        {
            List<object> l = new List<object>();
            string q = string.Format("match (:KhachHang)-[r:MUA]-(s:Sach) where r.NgayMua.year={0} with s.TheLoai as mang unwind mang  as tl  return tl, count(*) as soluongtl ORDER BY soluongtl DESC limit {1}", nam, limit);
            var results = Neo4jConfig.QueryCypher(q);

            foreach (IRecord res in results)
            {
                string tenTL = res["tl"].As<string>();
                string soluongTL = res["soluongtl"].As<string>();

                //Console.WriteLine(kh);
                l.Add(new { tenTL, soluongTL });
            }
            return l;
        }
    }
}
