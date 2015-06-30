/*
 * Copyright 2014-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 *
 * Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located in the "license" file accompanying this file.
 * See the License for the specific language governing permissions and limitations under the License.
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for AWS Import Export.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public static class ImportExportActionIdentifiers
    {
        public static readonly ActionIdentifier AllImportExportActions = new ActionIdentifier("importexport:*");

        public static readonly ActionIdentifier CreateJob = new ActionIdentifier("importexport:CreateJob");
        public static readonly ActionIdentifier UpdateJob = new ActionIdentifier("importexport:UpdateJob");
        public static readonly ActionIdentifier CancelJob = new ActionIdentifier("importexport:CancelJob");
        public static readonly ActionIdentifier ListJobs = new ActionIdentifier("importexport:ListJobs");
        public static readonly ActionIdentifier GetStatus = new ActionIdentifier("importexport:GetStatus");
    }
}
