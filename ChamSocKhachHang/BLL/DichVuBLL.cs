using ChamSocKhachHang.DAL;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocKhachHang.BLL
{
    public class DichVuBLL
    {
        public string maDV { get; set; }
        public string tenDV { get; set; }

        public DichVuBLL() { }

        public DichVuBLL(string maDV, string tenDV)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
        }

        public List<DichVuBLL> getListDichVus()
        {
            List<DichVuBLL> l = new List<DichVuBLL>();

            var results = Neo4jConfig.QueryCypher("MATCH (n:DichVu) RETURN n");

            foreach (IRecord res in results)
            {
                var node = res["n"].As<INode>();

                DichVuBLL dv = new DichVuBLL(
                    node["MaDichVu"].ToString(),
                    node["TenDichVu"].ToString()
                );
                l.Add(dv);
            }

            return l;
        }

    }
}
