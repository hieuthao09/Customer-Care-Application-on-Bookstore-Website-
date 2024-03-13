using ChamSocKhachHang.DAL;
using ChamSocKhachHang.gui;
using Neo4j.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChamSocKhachHang.BLL
{
    public class KhachHangBLL
    {
        public string MaKH { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string TenKH { get; set; }


        public KhachHangBLL() {
        }

        public List<KhachHangBLL> getListKhachHang() {
            List<KhachHangBLL> l = new List<KhachHangBLL>();

            var results = Neo4jConfig.QueryCypher("MATCH (n:KhachHang) RETURN n");

            foreach (IRecord res in results)
            {
                var node = res["n"].As<INode>();

                KhachHangBLL kh = new KhachHangBLL()
                {
                    MaKH = node["MaKH"].ToString(),
                    TenKH = node["TenKH"].ToString(),
                    Email = node["Email"].ToString(),
                    SDT = node["SDT"].ToString()
                };
                //Console.WriteLine(kh);
                l.Add(kh);
            }

            return l;
        }


        public void themKhachHang(string maKH, string tenKh, string email,string sdt )
        {
            try
            {
                string q = string.Format("Create (kh:KhachHang {{MaKH: '{0}', TenKH:'{1}', SDT:'{2}', Email:'{3}'}}) return kh", maKH, tenKh, sdt, email);
                Neo4jConfig.ExeuteWrite(q);
            }
            catch(Exception err)
            {
                throw err;
            }
            
        }

        public void xoaKhachHang(string maKH)
        {
            try
            {
                string q = string.Format("match (kh:KhachHang)-[ph:PHANHOI]-(dg:DanhGia), (kh)-[m:MUA]-(s:Sach),(kh)-[dk:DANGKY]-(dv:DichVu) where kh.MaKH='{0}' delete ph,m,dk", maKH);
                Neo4jConfig.ExeuteWrite(q);//xoa rel
                q = string.Format("match (kh:KhachHang) where kh.MaKH='{0}' delete kh", maKH);
                Neo4jConfig.ExeuteWrite(q);//xoa tt khach hang
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public void suaKhachHang(string maKH, string tenKh, string email, string sdt)
        {
            try
            {
                string q = string.Format("match (kh:KhachHang) where kh.MaKH='{0}' set kh.TenKH='{1}', kh.SDT='{2}', kh.Email='{3}' return kh", maKH, tenKh, sdt, email);
                Neo4jConfig.ExeuteWrite(q);
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public List<object> traCuuThongTinKhachHang(string strSearch)
        {
            List<object> l = new List<object>();
            string q = string.Empty;
            try
            {
                if (strSearch.StartsWith("KH"))
                {
                    q = string.Format("match (dg)-[ph:PHANHOI]-(kh:KhachHang)-[m:MUA]-(s) where kh.MaKH='{0}' return kh,m,s,ph,dg", strSearch);
                }
                else if(strSearch.StartsWith("0") && strSearch.Length == 10)
                {
                    q = string.Format("match (dg)-[ph:PHANHOI]-(kh:KhachHang)-[m:MUA]-(s) where kh.SDT='{0}' return kh,m,s,ph,dg", strSearch);
                }
                else
                {
                    q = string.Format("match (dg)-[ph:PHANHOI]-(kh:KhachHang)-[m:MUA]-(s) where kh.TenKH CONTAINS '{0}' return kh,m,s,ph,dg", strSearch);
                }
                var results = Neo4jConfig.QueryCypher(q);

                foreach (IRecord res in results)
                {
                    var node = res["kh"].As<INode>();

                    //khach hang
                    KhachHangBLL kh = new KhachHangBLL()
                    {
                        MaKH = node["MaKH"].ToString(),
                        TenKH = node["TenKH"].ToString(),
                        Email = node["Email"].ToString(),
                        SDT = node["SDT"].ToString()
                    };

                    //PhanHoi
                    IRelationship relation = res["ph"].As<IRelationship>();
                    DateTime ngayPH;
                    if (relation.Properties.ContainsKey("NgayPH")){
                        ngayPH = relation.Properties["NgayPH"].As<ZonedDateTime>().ToDateTimeOffset().DateTime;
                    }
                    else{
                        ngayPH = new DateTime();
                    }

                    //DanhGia
                    node = res["dg"].As<INode>();
                    DanhGiaBLL dg;
                    if (!node.Properties.ContainsKey("SoSao")){
                        dg = new DanhGiaBLL(5,
                            node["Noidung"].As<string>(),
                            node["MaDanhGia"].As<string>()
                        );
                    }
                    else{
                        dg = new DanhGiaBLL(
                            node["SoSao"].As<int>(),
                            node["Noidung"].As<string>(),
                            node["MaDanhGia"].As<string>()
                        );
                    }

                    //mua
                    relation = res["m"].As<IRelationship>();
                    DateTime NgayMua;
                    if (relation.Properties.ContainsKey("NgayMua"))
                    {
                        NgayMua = relation.Properties["NgayMua"].As<LocalDate>().ToDateTime();
                    }
                    else
                    {
                        NgayMua = new DateTime();
                    }

                    //Sach
                    node = res["s"].As<INode>();
                    SachBLL Sach = new SachBLL(
                        node["MaSach"].As<string>(),
                        node["TenSach"].As<string>(),
                        node["TheLoai"].As<List<string>>(),
                        node["HinhAnh"].As<string>(),
                        node["MoTa"].As<string>(),
                        node["Gia"].As<long>()
                    );

                    l.Add(new { KH=kh, S = Sach, DG = dg, ngayMua = NgayMua, ngayPH = ngayPH});
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return l;
        }

        public KhachHangBLL getThongTinKhachHang(string str)
        {
            string q = string.Empty;
            try
            {
                if (str.StartsWith("KH"))
                {
                    q = string.Format("match(p:KhachHang) where p.MaKH = '{0}' return p", str);
                }
                else if (str.StartsWith("0") && str.Length == 10)
                {
                    q = string.Format("match(p:KhachHang) where p.SDT = '{0}' return p", str);
                }
                else if(str.Contains("@"))
                {
                    q = string.Format("match(p:KhachHang) where p.Email = '{0}' return p", str);
                }

                var results = Neo4jConfig.QueryCypher(q);
                INode node = results.FirstOrDefault()["p"].As<INode>();
                KhachHangBLL kh = new KhachHangBLL()
                {
                    MaKH = node["MaKH"].ToString(),
                    TenKH = node["TenKH"].ToString(),
                    Email = node["Email"].ToString(),
                    SDT = node["SDT"].ToString()
                };
                return kh;
                
            }
            catch (Exception err)
            {
                throw err;
            }
            return null;
        }

        //public override string ToString()
        //{
        //    return string.Format("{0}, {1}, {2}, {3}", MaKH, TenKH, Email, SDT);
        //}
    }
}
