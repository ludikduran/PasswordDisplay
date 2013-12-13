using System;
using System.Web.UI.WebControls;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Services.Localization;
using DotNetNuke.UI.Utilities;
using LD2.PasswordDisplay.Components;
using DotNetNuke.Common.Utilities;
using System.Collections;
using System.Collections.Generic;
using DotNetNuke.Entities.Users;

namespace LD2.PasswordDisplay
{
    public partial class view : PasswordDisplayModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var list = UserController.GetUsers(0);
                rptUserList.DataSource = list;
                rptUserList.DataBind();
            }
            catch (Exception exc)
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }


    }
}