using PMAWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMAWeb.Tools
{
    public class SessionManager
    {
        public static List<ProjectModel> ProjectsList
        {
            get
            {
                return HttpContext.Current.Session[ConstantsManager.ProjectsListSession] as List<ProjectModel>;
            }
            set
            {
                HttpContext.Current.Session[ConstantsManager.ProjectsListSession] = value;
            }
        }
    }
}