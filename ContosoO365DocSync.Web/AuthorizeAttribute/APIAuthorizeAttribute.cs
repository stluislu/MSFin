﻿/*   
 *   * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.  
 *   * See LICENSE in the project root for license information.  
 */

using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace ContosoO365DocSync.Web
{
    /// <summary>
    /// return 410 status code if current request is not authorized.
    /// </summary>
    public class APIAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var response = HttpContext.Current.Response;
            response.SuppressFormsAuthenticationRedirect = true;
            response.StatusCode = 410;
            response.End();
        }
    }
}