﻿using System;
using Xamarin.Utilities.Core.ViewModels;
using RepositoryStumble.Core.ViewModels.Repositories;
using RepositoryStumble.Core.Services;

namespace RepositoryStumble.Core.ViewModels.Stumble
{
    public class StumbleViewModel : BaseRepositoryViewModel
    {
        public StumbleViewModel(IApplicationService applicationService)
            : base(applicationService)
        {
        }
    }
}

