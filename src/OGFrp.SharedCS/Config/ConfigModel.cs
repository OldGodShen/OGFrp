﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGFrp.UI
{
    /// <summary>
    /// ConfigModel
    /// </summary>
    public class ConfigModel
    {
        /// <summary>
        /// 设置：设置名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 设置：记录值
        /// </summary>
        public string Val { get; set; }
    }

    public partial class Config
    {
        /// <summary>
        /// 设置：语言
        /// </summary>
        public ConfigModel Lang = new ConfigModel
        {
            Name = "Lang",
            Val = "zh_cn"
        };

        /// <summary>
        /// 设置：用户名
        /// </summary>
        public ConfigModel Username = new ConfigModel
        {
            Name = "Username"
        };

        /// <summary>
        /// 设置：密码
        /// </summary>
        public ConfigModel Password = new ConfigModel
        {
            Name = "Password"
        };

        /// <summary>
        /// 设置：记住密码
        /// </summary>
        public ConfigModel RmbPsw = new ConfigModel
        {
            Name = "RmbPsw"
        };

        /// <summary>
        /// 设置：Frpc启动模式
        /// </summary>
        public ConfigModel FrpcLaunchMode = new ConfigModel
        {
            Name = "FrpcLaunchMode",
            Val = "proxy"
        };

        public ConfigModel Theme = new ConfigModel
        {
            Name = "Theme",
            Val = "System"
        };
    }
}
