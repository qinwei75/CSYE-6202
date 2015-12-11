using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
{

    public class UserAccount
    {
        public enum UserType
        {
            Admin,
            Regular
        }
        public string UserName {  get; set; }
        public string Password {  get; set; }
        public string Type {  get; set; }



    }
}
