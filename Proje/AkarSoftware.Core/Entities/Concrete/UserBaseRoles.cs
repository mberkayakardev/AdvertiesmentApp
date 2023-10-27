﻿using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    public class UserBaseRoles : BaseEntity
    {

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int BaseRoleId { get; set; }
        public BaseRole BaseRole { get; set; }


    }
}