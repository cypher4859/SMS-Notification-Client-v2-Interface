﻿using SMS_Notification_Client_v2_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMS_Notification_Client_v2_Interface.Transformers
{
    abstract class BaseTransformer
    {
        public abstract BaseSmsResource InjectData { get; }
    }
}
