﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMOSEC.Domain.Entity;

namespace SwebSECUI
{
    /// <summary>
    /// 部门分配人员列表属性
    /// </summary>
    class DataGridviewbyUser : coreUser
    {
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool SelectCheck { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepName { get; set; }
    }
}
