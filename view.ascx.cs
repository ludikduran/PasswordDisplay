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
                var userlist = UserController.GetUsers(0);
                rptUserList.DataSource = userlist;
                rptUserList.DataBind();

                ArrayList passwordList = new ArrayList();
                foreach(UserInfo user in userlist){
                    passwordList.Add(GetPassword(0, user, ""));
                }

                rptPassword.DataSource = passwordList;
                rptPassword.DataBind();
            }
            catch (Exception exc)
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        private string GetPassword(int portalID, UserInfo user, string passwordAnswer)
        {
            string password = "";

            if (user != null)
            {
                password = UserController.GetPassword(ref user, passwordAnswer);
            }
            return password;
        }
    }
}