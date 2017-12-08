﻿/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using NFine.Domain.Entity.SystemManage;
using Microsoft.EntityFrameworkCore;


namespace NFine.Mapping.SystemManage
{
    public class OrganizeMap : EntityTypeConfiguration<OrganizeEntity>
    {
        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizeEntity>().ToTable("Sys_Organize").HasKey(_ => _.F_Id);
        }
    }
}
