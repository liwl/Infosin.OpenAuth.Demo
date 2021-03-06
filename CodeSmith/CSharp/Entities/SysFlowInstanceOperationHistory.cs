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
	/// 工作流实例操作记录
	/// </summary>
    public partial class SysFlowInstanceOperationHistory : Entity
    {
        public SysFlowInstanceOperationHistory()
        {
          this.InstanceId= string.Empty;
          this.Content= string.Empty;
          this.CreateDate= DateTime.Now;
          this.CreateSysUserId= string.Empty;
          this.CreateSysUserName= string.Empty;
        }

        /// <summary>
	    /// 实例进程Id
	    /// </summary>
        public string InstanceId { get; set; }
        /// <summary>
	    /// 操作内容
	    /// </summary>
        public string Content { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
	    /// 创建用户主键
	    /// </summary>
        public string CreateSysUserId { get; set; }
        /// <summary>
	    /// 创建用户
	    /// </summary>
        public string CreateSysUserName { get; set; }

    }
}