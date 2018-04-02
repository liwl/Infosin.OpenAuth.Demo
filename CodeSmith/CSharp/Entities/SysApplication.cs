﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace InfosinOpenAuthDB.Repository.Domain
{
    /// <summary>
	/// 应用
	/// </summary>
    public partial class SysApplication : Entity
    {
        public SysApplication()
        {
          this.Name= string.Empty;
          this.AppId= string.Empty;
          this.AppKey= string.Empty;
          this.Description= string.Empty;
          this.Icon= string.Empty;
          this.CreateTime= DateTime.Now;
          this.CreateSysUser= string.Empty;
        }

        /// <summary>
	    /// 名称
	    /// </summary>
        public string Name { get; set; }
        /// <summary>
	    /// 应用ID
	    /// </summary>
        public string AppId { get; set; }
        /// <summary>
	    /// 应用密钥
	    /// </summary>
        public string AppKey { get; set; }
        /// <summary>
	    /// 应用描述
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 应用图标
	    /// </summary>
        public string Icon { get; set; }
        /// <summary>
	    /// 是否可用
	    /// </summary>
        public bool Disable { get; set; }
        /// <summary>
	    /// 创建日期
	    /// </summary>
        public System.DateTime? CreateTime { get; set; }
        /// <summary>
	    /// 创建人
	    /// </summary>
        public string CreateSysUser { get; set; }

    }
}