﻿using System;

namespace SimpleDemo.Model
{
    public class GeneralResultModel
    {
        public ResultCodeEnum Code { get; set; }

        public object Data { get; set; }

        public string Message { get; set; }
    }
}
