using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppointment.MVP
{
    public interface ILoginPage : IView
    {

        TextBox TextUserName { get; }
        TextBox TextPassword { get; }
        Button ButtonLogin { get; }

        event EventHandler ViewLoadEvent;
        event EventHandler btnLogin_Click;
    }
}
