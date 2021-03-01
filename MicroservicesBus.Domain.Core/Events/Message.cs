﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
