/* 
 * Copyright 2008-2013 Mohawk College of Applied Arts and Technology
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
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MohawkCollege.EHR.HL7v3.MIF.MIF20.Vocabulary
{
    /// <summary>
    /// Defines a set of extensions to the semantics of an existing code sstem created by someone
    /// other than the author of the code system
    /// </summary>
    [XmlType(TypeName = "CodeSystemSuppliment", Namespace = "urn:hl7-org:v3/mif2")]
    public class CodeSystemSupplement : CodeSystemBase
    {
        /// <summary>
        /// The identifier for the extension
        /// </summary>
        [XmlAttribute("SupplementId")]
        public string SupplementId { get; set; }
        /// <summary>
        /// Identifies extensions to a particular release associated with the code system
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), XmlElement("codeSystemVersionSupplement")]
        public List<CodeSystemVersionSupplement> CodeSystemVersionSupplement { get; set; }
    }
}