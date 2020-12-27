using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoShop.Domain;


namespace VideoShop.Data
{
    // this class created for communication with database by EF core.
    public class VideoShopDbContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public VideoShopDbContext(DbContextOptions<VideoShopDbContext> options): base(options)
        {

        }
    }
}
