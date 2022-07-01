﻿using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodetech.Administrador.Domain.Exception
{
    [Serializable]
    public class BusinessException : System.Exception
    {
        public BusinessException(string message) : base(message)
        {

        }

        public BusinessException(string message, System.Exception exception) : base(message, exception)
        {

        }

        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
