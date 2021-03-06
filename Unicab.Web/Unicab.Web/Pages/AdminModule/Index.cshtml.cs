﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unicab.Api.Models;
using Unicab.Web.Services;

namespace Unicab.Web.Pages.AdminModule
{
    public class IndexModel : PageModel
    {
        public List<Admin> Admins { get; private set; }

        private IAdminManagementService adminManagementService;

        public IndexModel(IAdminManagementService service)
        {
            adminManagementService = service;
        }

        public async Task OnGetAsync()
        {
            Admins = await adminManagementService.GetAdminsList();
        }
    }
}