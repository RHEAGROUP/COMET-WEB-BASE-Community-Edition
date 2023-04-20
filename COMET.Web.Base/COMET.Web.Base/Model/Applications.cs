// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Applications.cs" company="RHEA System S.A.">
//    Copyright (c) 2023 RHEA System S.A.
// 
//    Authors: Sam Gerené, Alex Vorobiev, Alexander van Delft, Jaime Bernar, Théate Antoine
// 
//    This file is part of COMET WEB Base Community Edition
//    The COMET WEB Base Community Edition is the RHEA Basic infrastructure to create custom E-TM-10-25 web based dashboards.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// 
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

namespace COMET.Web.Base.Model
{
    using Common.Model;

    /// <summary>
    /// Provides all available application contained into the current web application
    /// </summary>
    public class Applications
    {
        /// <summary>
        /// List of <see cref="Application" /> with Name, Color, Icon and Description data
        /// </summary>
        public static List<Application> ExistingApplications => new();
    }
}