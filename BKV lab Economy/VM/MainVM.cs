using BKV_lab_Economy.Core_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKV_lab_Economy.VM
{
    public class MainVM : CoreViewModel
    {

        public CoreCommand CoreCommand { get; set; }

        public MainVM()
        {
                
        }
    }
}
