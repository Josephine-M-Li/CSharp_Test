using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CSharp_Test.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CSharp_TestUser class
public class CSharp_TestUser : IdentityUser
{
    public Guid id { get; set; }
    public string org_id { get; set; }
    public string name { get; set; }
    public string birthday { get; set; }
    public string email { get; set; }
    public string account { get; set; }
    public string password { get; set; }
    public int status { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }


}

