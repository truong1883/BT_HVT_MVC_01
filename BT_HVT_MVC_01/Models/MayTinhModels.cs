using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_HVT_MVC_01.Models
{
    public class MayTinhModels
    {
        public double So1 { get; set; }

        public double So2 { get; set; }

        public String PhepTinh { get; set; }

        public Double KetQua()
        {
            double ketqua = 0;
            switch (PhepTinh)
            {
                case "+": ketqua = So1 + So2; break;
                case "-": ketqua = So1 - So2; break;
                case "*": ketqua = So1 * So2; break;
                case "/": ketqua = So1 / So2; break;
            }
            return ketqua;
        }
    }
}
