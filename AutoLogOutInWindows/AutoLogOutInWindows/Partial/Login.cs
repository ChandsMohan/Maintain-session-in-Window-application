using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLogOutInWindows
{
    public partial class Login
    {
        public Login GetLog(string UN, string Pwd)
        {
            try
            {
                using (EntityInheritanceEntities context = new EntityInheritanceEntities())
                {
                    Login log = context.Logins.FirstOrDefault(x => x.UserName == UN && x.Password == Pwd);
                    return log;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }
    }
}
