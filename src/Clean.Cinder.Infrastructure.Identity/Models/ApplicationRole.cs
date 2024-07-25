using Microsoft.AspNetCore.Identity;
using System;

namespace Clean.Cinder.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
