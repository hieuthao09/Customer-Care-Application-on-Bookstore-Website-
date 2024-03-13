using ChamSocKhachHang.DAL;
using ChamSocKhachHang.gui;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChamSocKhachHang.BLL
{
    public class QLDichVuKH
    {
        public KhachHangBLL KhachHang { get; set; }
        public DichVuBLL DichVu { get; set; }
        public DateTime ngayDK { get; set; }

        public QLDichVuKH() { }

        public List<QLDichVuKH> getListDichVu_KhachHang_DK()
        {
            List<QLDichVuKH> l = new List<QLDichVuKH>();
            var results = Neo4jConfig.QueryCypher("match (dv:DichVu)-[dk:DANGKY]-(kh:KhachHang) return dv,dk,kh");
            foreach (IRecord res in results)
            {
                QLDichVuKH qldv = new QLDichVuKH();
                //dich vu
                var node = res["dv"].As<INode>();
                DichVuBLL dv = new DichVuBLL(
                    node["MaDichVu"].ToString(),
                    node["TenDichVu"].ToString()
                );
                qldv.DichVu = dv;

                //Dang ky
                IRelationship relation = res["dk"].As<IRelationship>();
                DateTime ngayDK;
                if (relation.Properties.ContainsKey("NgayDangky")){
                    ngayDK = relation.Properties["NgayDangky"].As<LocalDate>().ToDateTime();
                }
                else{
                    ngayDK = new DateTime();
                }

                qldv.ngayDK = ngayDK;

                //Khach Hang
                node = res["kh"].As<INode>();
                KhachHangBLL kh = new KhachHangBLL()
                {
                    MaKH = node["MaKH"].ToString(),
                    TenKH = node["TenKH"].ToString(),
                    Email = node["Email"].ToString(),
                    SDT = node["SDT"].ToString()
                };
                qldv.KhachHang = kh;

                l.Add(qldv);
            }
            return l;
        }

        public void HuyDichVu(string maDV, string maKH)
        {
            try
            {
                string q = string.Format("match (dv:DichVu)-[dk:DANGKY]-(kh:KhachHang) where dv.MaDichVu = '{0}' and kh.MaKH='{1}' delete dk", maDV, maKH);
                Neo4jConfig.ExeuteWrite(q);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void DangKyDichVu(KhachHangBLL kh, DateTime NgayDangKy, string maDV)
        {
            try
            {
                string q = string.Format("match (dv:DichVu{{MaDichVu : '{1}'}}),(kh:KhachHang{{MaKH:'{0}'}}) create (kh)-[:DANGKY{{NgayDangky:date('{2}')}}]->(dv)", kh.MaKH, maDV, NgayDangKy.ToString("yyyy-MM-dd"));
                Neo4jConfig.ExeuteWrite(q);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
