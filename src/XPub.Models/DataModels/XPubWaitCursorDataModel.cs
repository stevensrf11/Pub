using System;
using System.Collections.Generic;
using System.Text;
using XPub.Resources.Enums;

namespace XPub.Models.DataModels
{
    public class XPubWaitCursorDataModel
    {
        public string Message { get; set; }
        public WaitCursorEnums WaitCursorEnum { get; set; }
        public ViewEnums ViewAppEnums { get; set; }

    }
}
