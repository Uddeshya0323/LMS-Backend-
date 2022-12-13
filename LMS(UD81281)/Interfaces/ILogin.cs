using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_UD81281_.Models;



namespace LMS_UD81281_.Interfaces
{
    interface ILogin
    {
        Task<int> SignIn(Login login);
    }
}