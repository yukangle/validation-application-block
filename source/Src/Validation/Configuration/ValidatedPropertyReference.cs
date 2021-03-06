// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Configuration
{
    /// <summary>
    /// Represents the validation information for a property.
    /// </summary>
    /// <seealso cref="ValidatedTypeReference"/>
    /// <seealso cref="ValidationRulesetData"/>
    /// <seealso cref="ValidatedMemberReference"/>
    [ResourceDescription(typeof(DesignResources), "ValidatedPropertyReferenceDescription")]
    [ResourceDisplayName(typeof(DesignResources), "ValidatedPropertyReferenceDisplayName")]
    [NameProperty("Name", NamePropertyDisplayFormat = "Property: {0}")]
    public sealed class ValidatedPropertyReference : ValidatedMemberReference
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ValidatedPropertyReference"/> class.</para>
        /// </summary>
        public ValidatedPropertyReference()
        { }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ValidatedPropertyReference"/> class with a name.</para>
        /// </summary>
        /// <param name="name">The name for the instance.</param>
        public ValidatedPropertyReference(string name)
            : base(name)
        { }
    }
}
