using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.form;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface Iaccount
    {
        Task<acc> Login(loginform user);
        Task<acc> Logout();
    }
}
