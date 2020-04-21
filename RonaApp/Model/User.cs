using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Model
{
    public class User
    {

        public string Username { get; set; }
        public string Pass { get; set; }
        public Permission Permissions { get; set; }

        public User(string username, string pass, Permission permissions)
        {
            Username = username;
            Pass = pass;
            Permissions = permissions;
        }

        public class Permission
        {

            public Boolean Add { get; set; }
            public Boolean Visualize { get; set; }
            public AllPermissions AllPermissions { get; set; }

        }

        public class AllPermissions
        {

            public Boolean Add { get; set; }
            public Boolean Visualize { get; set; }

        }

    }
}