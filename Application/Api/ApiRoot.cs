using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Revolution.Api.Api_Callbacks;
using System.Reflection;
using Revolution.Api.Api_Interface;

namespace Revolution.Api
{
    class ApiRoot
    {
        #region Needed

        public static ApiDatabaseCallback DatabaseCallback { get { return new ApiDatabaseCallback(); } }

        #endregion
    }
}
