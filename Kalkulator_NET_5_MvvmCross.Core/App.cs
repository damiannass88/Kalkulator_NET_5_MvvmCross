using Kalkulator_NET_5_MvvmCross.Core.ViewModels;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_NET_5_MvvmCross.Core
{
    public class App : MvxApplication 
    {
        public override void Initialize()
        { 
            RegisterAppStart<KalkulatorViewModel>();
        }
    }
}
