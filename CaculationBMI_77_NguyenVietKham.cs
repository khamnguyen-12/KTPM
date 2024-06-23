using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79_NguyenVietKham_BaoCao_KTPM
{
    public class CaculationBMI_79_NguyenVietKham
    {

        private double height_79_Kham, weight_79_kham;
        public CaculationBMI_79_NguyenVietKham(double height_79_Kham, double weight_79_kham)
        {
            this.height_79_Kham = height_79_Kham;
            this.weight_79_kham = weight_79_kham;
        }



        public string CalculateBMI_79_Kham()
        {
            string results ="";
            double kq = this.weight_79_kham / (this.height_79_Kham * this.height_79_Kham);
            if (kq <= 18.5)
                results = "gay";
            else if (kq >= 18.5 && kq <= 25)
                results = "binh thuong";
            else if (kq >= 25 && kq <= 30)
                results = "thua can";
            else if (kq >= 30)
                results = "beo";
            else
                results = "error";
            return results;
        }

    }
}
