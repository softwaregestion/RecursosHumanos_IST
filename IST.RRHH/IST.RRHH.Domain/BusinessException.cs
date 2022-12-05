﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH.Domain
{
    [Serializable]
    internal class BusinessException : Exception
    {
        public BusinessException()
        {
        }

        public BusinessException(string message) : base(message)
        {

        }

        public BusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}