﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugar
{
    public partial interface IDMLBuilder
    {
        string SqlTemplate { get; }
        List<SugarParameter> Parameters { get; set; }
        SqlSugarEngine  Context { get; set; }
        StringBuilder sql { get; set; }
        string ToSqlString();
        void Clear();
    }
}
