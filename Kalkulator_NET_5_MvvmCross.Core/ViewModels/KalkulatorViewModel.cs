using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_NET_5_MvvmCross.Core.ViewModels
{
   public class KalkulatorViewModel : MvxViewModel
    {
        private string myVar;

        public string MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}
