using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_NET_5_MvvmCross.Core.Services
{
    public class KalkulatorService : IKalkulatorService
    {
        private readonly DataTable _dataTable = new();

        public string MathSumme(string ScreenVal)
        {
            return Math.Round(Convert.ToDouble(_dataTable.Compute(ScreenVal.Replace(",", "."), "")), 3).ToString();
        }
    }
}
