﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantFallDetector.Services
{
    public interface INavigationService
    {
        void NavigateToContactDetailsPage(object contact);

        void NavigateToMainPage(object telefono);
    }
}
