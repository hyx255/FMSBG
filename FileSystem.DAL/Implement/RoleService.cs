﻿/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-11 16:08:21 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.DAL
{
    public class RoleService : BaseService<Role>,IRoleService
    {
        public override IQueryInfo QueryInfo => new BaseQueryInfo("ACL_Role");

        public List<Role> GetRoles()
        {
            throw new NotImplementedException();
        }

        public List<Role> GetRolesByUID(int uid)
        {
            throw new NotImplementedException();
        }
    }
}
