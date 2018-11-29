using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace XCode.Membership
{
    /// <summary>学生</summary>
    [Serializable]
    [DataObject]
    [Description("学生")]
    [BindIndex("IU_Student_Name", true, "Name")]
    [BindTable("Student", Description = "学生", ConnName = "Membership", DbType = DatabaseType.None)]
    public partial class Student : IStudent
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>名称。登录用户名</summary>
        [DisplayName("名称")]
        [Description("名称。登录用户名")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("Name", "名称。登录用户名", "", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _Password;
        /// <summary>密码</summary>
        [DisplayName("密码")]
        [Description("密码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Password", "密码", "")]
        public String Password { get { return _Password; } set { if (OnPropertyChanging(__.Password, value)) { _Password = value; OnPropertyChanged(__.Password); } } }

        private SexKinds _Sex;
        /// <summary>性别。未知、男、女</summary>
        [DisplayName("性别")]
        [Description("性别。未知、男、女")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Sex", "性别。未知、男、女", "")]
        public SexKinds Sex { get { return _Sex; } set { if (OnPropertyChanging(__.Sex, value)) { _Sex = value; OnPropertyChanged(__.Sex); } } }

        private Int32 _Age;
        /// <summary>年龄</summary>
        [DisplayName("年龄")]
        [Description("年龄")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Age", "年龄", "")]
        public Int32 Age { get { return _Age; } set { if (OnPropertyChanging(__.Age, value)) { _Age = value; OnPropertyChanged(__.Age); } } }

        private String _Mail;
        /// <summary>邮件</summary>
        [DisplayName("邮件")]
        [Description("邮件")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Mail", "邮件", "")]
        public String Mail { get { return _Mail; } set { if (OnPropertyChanging(__.Mail, value)) { _Mail = value; OnPropertyChanged(__.Mail); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get { return _UpdateTime; } set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } } }

        private Boolean _Enable;
        /// <summary>启用</summary>
        [DisplayName("启用")]
        [Description("启用")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Enable", "启用", "")]
        public Boolean Enable { get { return _Enable; } set { if (OnPropertyChanging(__.Enable, value)) { _Enable = value; OnPropertyChanged(__.Enable); } } }

        private Int32 _Logins;
        /// <summary>登录次数</summary>
        [DisplayName("登录次数")]
        [Description("登录次数")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Logins", "登录次数", "")]
        public Int32 Logins { get { return _Logins; } set { if (OnPropertyChanging(__.Logins, value)) { _Logins = value; OnPropertyChanged(__.Logins); } } }

        private DateTime _LastLogin;
        /// <summary>最后登录</summary>
        [DisplayName("最后登录")]
        [Description("最后登录")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("LastLogin", "最后登录", "")]
        public DateTime LastLogin { get { return _LastLogin; } set { if (OnPropertyChanging(__.LastLogin, value)) { _LastLogin = value; OnPropertyChanged(__.LastLogin); } } }

        private String _LastLoginIP;
        /// <summary>最后登录IP</summary>
        [DisplayName("最后登录IP")]
        [Description("最后登录IP")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("LastLoginIP", "最后登录IP", "")]
        public String LastLoginIP { get { return _LastLoginIP; } set { if (OnPropertyChanging(__.LastLoginIP, value)) { _LastLoginIP = value; OnPropertyChanged(__.LastLoginIP); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.Name : return _Name;
                    case __.Password : return _Password;
                    case __.Sex : return _Sex;
                    case __.Age : return _Age;
                    case __.Mail : return _Mail;
                    case __.UpdateTime : return _UpdateTime;
                    case __.Enable : return _Enable;
                    case __.Logins : return _Logins;
                    case __.LastLogin : return _LastLogin;
                    case __.LastLoginIP : return _LastLoginIP;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Password : _Password = Convert.ToString(value); break;
                    case __.Sex : _Sex = (SexKinds)Convert.ToInt32(value); break;
                    case __.Age : _Age = Convert.ToInt32(value); break;
                    case __.Mail : _Mail = Convert.ToString(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    case __.Enable : _Enable = Convert.ToBoolean(value); break;
                    case __.Logins : _Logins = Convert.ToInt32(value); break;
                    case __.LastLogin : _LastLogin = Convert.ToDateTime(value); break;
                    case __.LastLoginIP : _LastLoginIP = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得学生字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>名称。登录用户名</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>密码</summary>
            public static readonly Field Password = FindByName(__.Password);

            /// <summary>性别。未知、男、女</summary>
            public static readonly Field Sex = FindByName(__.Sex);

            /// <summary>年龄</summary>
            public static readonly Field Age = FindByName(__.Age);

            /// <summary>邮件</summary>
            public static readonly Field Mail = FindByName(__.Mail);

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            /// <summary>启用</summary>
            public static readonly Field Enable = FindByName(__.Enable);

            /// <summary>登录次数</summary>
            public static readonly Field Logins = FindByName(__.Logins);

            /// <summary>最后登录</summary>
            public static readonly Field LastLogin = FindByName(__.LastLogin);

            /// <summary>最后登录IP</summary>
            public static readonly Field LastLoginIP = FindByName(__.LastLoginIP);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得学生字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>名称。登录用户名</summary>
            public const String Name = "Name";

            /// <summary>密码</summary>
            public const String Password = "Password";

            /// <summary>性别。未知、男、女</summary>
            public const String Sex = "Sex";

            /// <summary>年龄</summary>
            public const String Age = "Age";

            /// <summary>邮件</summary>
            public const String Mail = "Mail";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>启用</summary>
            public const String Enable = "Enable";

            /// <summary>登录次数</summary>
            public const String Logins = "Logins";

            /// <summary>最后登录</summary>
            public const String LastLogin = "LastLogin";

            /// <summary>最后登录IP</summary>
            public const String LastLoginIP = "LastLoginIP";
        }
        #endregion
    }

    /// <summary>学生接口</summary>
    public partial interface IStudent
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>名称。登录用户名</summary>
        String Name { get; set; }

        /// <summary>密码</summary>
        String Password { get; set; }

        /// <summary>性别。未知、男、女</summary>
        SexKinds Sex { get; set; }

        /// <summary>年龄</summary>
        Int32 Age { get; set; }

        /// <summary>邮件</summary>
        String Mail { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>启用</summary>
        Boolean Enable { get; set; }

        /// <summary>登录次数</summary>
        Int32 Logins { get; set; }

        /// <summary>最后登录</summary>
        DateTime LastLogin { get; set; }

        /// <summary>最后登录IP</summary>
        String LastLoginIP { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}