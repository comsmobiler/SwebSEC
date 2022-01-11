using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOSEC.DTOs.OutputDTO
{
   public class UserDetailDto
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string USER_ID { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string USER_NAME { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string USER_IMAGEID { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int U_Sex { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string U_Email { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string U_Tel { get; set; }


        /// <summary>
        /// 是否审批人
        /// </summary>
        public int U_IsCheck { get; set; }

        /// <summary>
        /// 是否抄送人
        /// </summary>
        public int U_IsCC { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime U_Birthday { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public string DEPARTMENTID { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DEPARTMENTNAME { get; set; }

        /// <summary>
        /// 手势
        /// </summary>
        public string U_Gestures { get; set; }
    }
}
