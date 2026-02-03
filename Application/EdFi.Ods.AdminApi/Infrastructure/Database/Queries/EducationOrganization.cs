// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdFi.Admin.DataAccess.Models
{
    public class EducationOrganizationDto
    {
        /// <summary>
        /// auto-incrementing primary key for the Education Organization record
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// ODS Instance Id for the Education Organization
        /// </summary>
        [Required]
        public int InstanceId { get; set; }

        /// <summary>
        /// Friendly name for the Education Organization, to be displayed
        /// </summary>
        [Required]
        [StringLength(100)]
        public string InstanceName { get; set; } = string.Empty;

        [Required]
        public int EducationOrganizationId { get; set; }

        /// <summary>
        /// Name of institution for the Education Organization
        /// </summary>
        [Required]
        [StringLength(75)]
        public string NameOfInstitution { get; set; } = string.Empty;

        /// <summary>
        /// Short name of institution for the Education Organization
        /// </summary>
        [StringLength(75)]
        public string ShortNameOfInstitution { get; set; } = string.Empty;

        /// <summary>
        /// Discriminator for the Education Organization
        /// </summary>
        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; } = string.Empty;

        /// <summary>
        /// Parent Id for the Education Organization
        /// </summary>
        public int ParentId { get; set; }
    }
}
