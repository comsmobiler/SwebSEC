using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.OutputDTO;

namespace SwebSECUI
{
    class UserDetails
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userID"></param>
        public UserDepDto getUser(string userID)
        {
            try
            {
                if (string.IsNullOrEmpty(userID) == true)
                {
                    throw new Exception("请输入电话号码！");

                }
                AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
                UserDepDto user = AutofacConfig.coreUserService.GetUseDepByUserID(userID);

                if (user != null)
                {
                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                    {
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                user.USER_IMAGEID = "boy";
                                break;
                            case (int)Sex.女:
                                user.USER_IMAGEID = "girl";
                                break;
                        }
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
