/* 
 * Copyright 2008/2009 Mohawk College of Applied Arts and Technology
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: $user$
 * Date: 01-09-2009
 **/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MohawkCollege.EHR.HL7v3.MIF.MIF10.Interfaces
{
    /// <summary>
    /// Defines how the CMET may be entered
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "CMET"), XmlType(TypeName = "CMETEntryKind", Namespace = "urn:hl7-org:v3/mif")]
    public enum CMETEntryKind
    {
        /// <summary>
        /// The base of the CMET is a kind of Act and may be entered via participation or 
        /// ActRelationship
        /// </summary>
        [XmlEnum("Act")]
        Act,
        /// <summary>
        /// The base of the CMET is a kind of entity and may be entered via a Role
        /// </summary>
        [XmlEnum("Entity")]
        Entity,
        /// <summary>
        /// The base of the CMET is a role whose scoping association is already
        /// used or not intended to be used
        /// </summary>
        [XmlEnum("Role(Played or Performed)")]
        RolePlayedOrPerformed,
        /// <summary>
        /// The base of the CMET is a role whose playing association is already used or not 
        /// intended to be used
        /// </summary>
        [XmlEnum("Role(Scoped or Performed)")]
        RoleScopedOrPerformed,
        /// <summary>
        /// The base fo the CMET is a role whose playing and scoping associations are already
        /// used or not intended to be used.
        /// </summary>
        [XmlEnum("Role(Performed only)")]
        RolePerformedOnly
    }
}