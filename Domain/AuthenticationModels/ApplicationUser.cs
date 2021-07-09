﻿using Microsoft.AspNet.Identity.EntityFramework;


namespace Domain.AuthenticationModels
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}