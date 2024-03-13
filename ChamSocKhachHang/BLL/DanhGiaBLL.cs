using ChamSocKhachHang.DAL;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocKhachHang.BLL
{
    public class DanhGiaBLL
    {
        public int SoSao { get; set;}
        public string Noidung { get; set;}
        public string MaDanhGia { get; set; }

        public DanhGiaBLL() { }

        public DanhGiaBLL(int soSao, string noidung, string maDanhGia)
        {
            SoSao = soSao;
            Noidung = noidung;
            MaDanhGia = maDanhGia;
        }

        public object getTraLoi_DanhGia(string maDanhGia)
        {
            Console.WriteLine("[ERROR]: "+maDanhGia);
            string q = string.Format("match(p:DanhGia)-[r:TRALOI]-(q:NhanVien) where p.MaDanhGia='{0}' return r", maDanhGia);
            var results = Neo4jConfig.QueryCypher(q);
            var temp = results.SingleOrDefault()["r"].As<IRelationship>();

            return new
            {
                NoiDung = temp["NoiDungTL"].As<string>(),
                NgayTraLoi = temp["NgayTL"].As<ZonedDateTime>().ToDateTimeOffset().DateTime.ToString("dd/MM/yyyy hh:mm tt")
            };
        }

        public void deleteDanhGia(string maDanhGia)
        {
            try
            {
                string q = string.Format("match (kh:KhachHang)-[ph:PHANHOI]-(dg:DanhGia)-[t:THUOC]-(s:Sach) where dg.MaDanhGia='{0}' delete ph,t", maDanhGia);
                Neo4jConfig.ExeuteWrite(q);//xoa rel
                q = string.Format("match (p:DanhGia) where p.MaDanhGia='{0}' delete p", maDanhGia);

                Neo4jConfig.ExeuteWrite(q);//xoa node
            }catch(Exception err)
            {
                throw err;
            }

        }

        public void TraLoiDanhGia(string maNV, string maDG, string noiDung, string date )
        {
            try
            {
                string q = string.Format(@"match (p:DanhGia),(q:NhanVien) where q.MaNV='{0}' and p.MaDanhGia='{1}' create (p)-[:TRALOI{{NoiDungTL:'{2}',NgayTL:datetime('{3}')}}]->(q)", maNV, maDG, noiDung, date);
                Neo4jConfig.ExeuteWrite(q);
            }
            catch(Exception err)
            {
                throw err;
            } 
        }

        public void CapNhatTraLoiDanhGia(string maNV, string maDG, string noiDung, string date)
        {
            try
            {
                string q = string.Format(@"match(p:DanhGia)-[r:TRALOI]-(q:NhanVien) where q.MaNV='{0}' and p.MaDanhGia='{1}' set r.NoiDungTL = '{2}' , r.NgayTL = datetime('{3}')", maNV, maDG, noiDung, date);
                Neo4jConfig.ExeuteWrite(q);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
