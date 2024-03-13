using ChamSocKhachHang.DAL;
using ChamSocKhachHang.gui;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ChamSocKhachHang.BLL
{
    public class QLDanhGiaBLL
    {
        public KhachHangBLL khachHang { get; set; }
        public DanhGiaBLL danhGias { get; set; }
        public string maSach { get; set; }
        public int SLSachKHMua { get; set; }
        public DateTime ngayMua { get; set; }
        public DateTime ngayPhanHoi { get; set; }

        public QLDanhGiaBLL() {
        }

        private List<QLDanhGiaBLL> loadData(IResult results)
        {
            List<QLDanhGiaBLL> l = new List<QLDanhGiaBLL>();
            foreach (IRecord res in results)
            {
                QLDanhGiaBLL qldg = new QLDanhGiaBLL();
                //KhachHang
                var node = res["kh"].As<INode>();
                KhachHangBLL kh = new KhachHangBLL()
                {
                    MaKH = node["MaKH"].ToString(),
                    TenKH = node["TenKH"].ToString(),
                    Email = node["Email"].ToString(),
                    SDT = node["SDT"].ToString()
                };
                qldg.khachHang = kh;

                //PhanHoi
                IRelationship relation = res["ph"].As<IRelationship>();
                DateTime ngayPH;
                if (relation.Properties.ContainsKey("NgayPH"))
                {
                    ngayPH = relation.Properties["NgayPH"].As<ZonedDateTime>().ToDateTimeOffset().DateTime;
                }
                else
                {
                    ngayPH = new DateTime();
                }

                qldg.ngayPhanHoi = ngayPH;

                //DanhGia
                node = res["dg"].As<INode>();
                DanhGiaBLL dg;
                if (!node.Properties.ContainsKey("SoSao"))
                {
                    dg = new DanhGiaBLL(5,
                        node["Noidung"].As<string>(),
                        node["MaDanhGia"].As<string>()
                    );
                }
                else
                {
                    dg = new DanhGiaBLL(
                        node["SoSao"].As<int>(),
                        node["Noidung"].As<string>(),
                        node["MaDanhGia"].As<string>()
                    );
                }

                qldg.danhGias = dg;

                //Sach
                qldg.maSach = res["MaSach"].ToString();
                qldg.SLSachKHMua = res["SLSachKHMua"].As<int>();

                l.Add(qldg);
            }
            return l;
        }

        public List<QLDanhGiaBLL> getDataDanhGiaChuaTraLoi()
        {
            var results = Neo4jConfig.QueryCypher("match (kh:KhachHang)-[ph:PHANHOI]-(dg:DanhGia)-[:THUOC]->(s:Sach) where not exists((dg)-[:TRALOI]-(:NhanVien)) return kh,ph,dg,s.MaSach as MaSach, count(s) as SLSachKHMua");

            return loadData(results);
        }

        public List<QLDanhGiaBLL> getDataDanhGiaDaTraLoi()
        {
            var results = Neo4jConfig.QueryCypher("match (kh:KhachHang)-[ph:PHANHOI]-(dg:DanhGia)-[:THUOC]->(s:Sach) where exists((dg)-[:TRALOI]-(:NhanVien)) return kh,ph,dg,s.MaSach as MaSach, count(s) as SLSachKHMua");

            return loadData(results);
        }

        public List<object> getDanhGiaTot()
        {
            var results = Neo4jConfig.QueryCypher("MATCH (s:Sach)-[r:THUOC]-(dg:DanhGia) WHERE dg.SoSao >= 4 RETURN dg,s.MaSach as MaSach,count(s.MaSach)");

            List<object> l = new List<object>();

            foreach (IRecord res in results)
            {
                //DanhGia
                var node = res["dg"].As<INode>();
                
                        
                l.Add(new {
                    SoSao = node["SoSao"].As<int>(),
                    Noidung = node["Noidung"].As<string>(),
                    MaDG = node["MaDanhGia"].As<string>(),
                    MaSach = res["MaSach"].As<string>()
                });
            }
            return l;
        }

        public List<object> getDanhGiaKhongTot()
        {
            var results = Neo4jConfig.QueryCypher("MATCH (s:Sach)-[r:THUOC]-(dg:DanhGia) WHERE not dg.SoSao >= 4 RETURN dg,s.MaSach as MaSach,count(s.MaSach)");

            List<object> l = new List<object>();

            foreach (IRecord res in results)
            {
                //DanhGia
                var node = res["dg"].As<INode>();


                l.Add(new
                {
                    SoSao = node["SoSao"].As<int>(),
                    Noidung = node["Noidung"].As<string>(),
                    MaDG = node["MaDanhGia"].As<string>(),
                    MaSach = res["MaSach"].As<string>()
                });
            }
            return l;
        }

        public List<object> getThoiGianPhanHoi(string thang)
        {
            string q = string.Empty;
            if (thang == null)
            {
                q = string.Format("MATCH (kh:KhachHang)-[ph:PHANHOI]->(dg:DanhGia)<-[tl:TRALOI]-(nv:NhanVien) WITH dg, kh, nv, ph.NgayPH AS NgayPH,tl.NgayTL AS NgayTL RETURN dg.MaDanhGia as MaDanhGia, NgayPH,NgayTL,duration.inDays(NgayPH, NgayTL).days as SoNgayPhanHoi");
            }
            else
            {
                q = string.Format("MATCH (kh:KhachHang)-[ph:PHANHOI]->(dg:DanhGia)<-[tl:TRALOI]-(nv:NhanVien) WITH dg, kh, nv, ph.NgayPH AS NgayPH,tl.NgayTL AS NgayTL Where tl.NgayTL.month = {0} RETURN dg.MaDanhGia as MaDanhGia, NgayPH,NgayTL,duration.inDays(NgayPH, NgayTL).days as SoNgayPhanHoi", thang);
            }
            var results = Neo4jConfig.QueryCypher(q);

            List<object> l = new List<object>();

            foreach (IRecord res in results)
            {
                //DanhGia
                l.Add(new
                {
                    SoSao = res["MaDanhGia"].As<string>(),
                    Noidung = res["NgayPH"].As<ZonedDateTime>().ToDateTimeOffset().DateTime,
                    MaDG = res["NgayTL"].As<ZonedDateTime>().ToDateTimeOffset().DateTime,
                    SoNgayPhanHoi = res["SoNgayPhanHoi"].As<string>()
                });
            }
            return l;
        }
    }
}
