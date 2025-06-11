using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;

namespace Malshinon.mddel
{
    public class IntelReports
    {
        public int Id;

        public string ReporterId;

        public string TargetId;

        public string Text;

        public DateTime Timestamp;

    }
}
