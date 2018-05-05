﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseLibrary.Validation.TestSupport.TestClasses
{
    public class DerivedTestTypeWithValidatorAttributesOnNewMethods : BaseTestTypeWithValidatorAttributesOnMethods
    {
        [MockValidator(false, MessageTemplate = "MethodWithMultipleAttributesNew-Message1")]
        public new object MethodWithMultipleAttributes()
        {
            return base.MethodWithMultipleAttributes();
        }
    }
}