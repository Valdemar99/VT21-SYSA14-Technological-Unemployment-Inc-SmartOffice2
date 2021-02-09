using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartOfficeApplication
{
    class VentilationSetting
    {
        private string[] ventilationSettingList = new string[] { "V1", "V2", "V3", "V4", "V5" };

        public string[] VentilationSettingList { get => ventilationSettingList; }
    }
}
