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
	/// 表单模板表
	/// </summary>
    public partial class SysForm : Entity
    {
        public SysForm()
        {
          this.Name= string.Empty;
          this.Fields= 0;
          this.ContentData= string.Empty;
          this.ContentParse= string.Empty;
          this.Content= string.Empty;
          this.SortCode= 0;
          this.Delete= 0;
          this.DbName= string.Empty;
          this.Enabled= 0;
          this.Description= string.Empty;
          this.CreateDate= DateTime.Now;
          this.CreateSysUserId= string.Empty;
          this.CreateSysUserName= string.Empty;
          this.ModifyDate= DateTime.Now;
          this.ModifySysUserId= string.Empty;
          this.ModifySysUserName= string.Empty;
        }

        /// <summary>
	    /// 表单名称
	    /// </summary>
        public string Name { get; set; }
        /// <summary>
	    /// 字段个数
	    /// </summary>
        public int Fields { get; set; }
        /// <summary>
	    /// 表单中的控件属性描述
	    /// </summary>
        public string ContentData { get; set; }
        /// <summary>
	    /// 表单控件位置模板
	    /// </summary>
        public string ContentParse { get; set; }
        /// <summary>
	    /// 表单原html模板未经处理的
	    /// </summary>
        public string Content { get; set; }
        /// <summary>
	    /// 排序码
	    /// </summary>
        public int SortCode { get; set; }
        /// <summary>
	    /// 删除标记
	    /// </summary>
        public int Delete { get; set; }
        /// <summary>
	    /// 数据库名称
	    /// </summary>
        public string DbName { get; set; }
        /// <summary>
	    /// 有效
	    /// </summary>
        public int Enabled { get; set; }
        /// <summary>
	    /// 备注
	    /// </summary>
        public string Description { get; set; }
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
        /// <summary>
	    /// 修改时间
	    /// </summary>
        public System.DateTime? ModifyDate { get; set; }
        /// <summary>
	    /// 修改用户主键
	    /// </summary>
        public string ModifySysUserId { get; set; }
        /// <summary>
	    /// 修改用户
	    /// </summary>
        public string ModifySysUserName { get; set; }

    }
}