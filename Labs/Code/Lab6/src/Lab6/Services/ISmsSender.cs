﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
