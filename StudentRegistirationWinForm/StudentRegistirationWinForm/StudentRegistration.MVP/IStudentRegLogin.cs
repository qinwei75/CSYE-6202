﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.MVP
{
    public interface IStudentRegLogin : IView
    {
        event EventHandler DataChanged;

    }
}
