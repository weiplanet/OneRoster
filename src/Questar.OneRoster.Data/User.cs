using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Questar.OneRoster.Data
{
    public class User : IdentityUser<int>, IBaseObject
    {
        public User(UserType type)
        {
            Type = type;
        }

        internal User()
        {
        }

        [Required] public virtual UserType? Type { get; internal set; }

        public virtual bool Enabled { get; set; }

        [Required]
        [MaxLength(64)]
        [PersonalData]
        public virtual string GivenName { get; set; }

        [MaxLength(64)] [PersonalData] public virtual string MiddleName { get; set; }

        [Required]
        [PersonalData]
        [MaxLength(64)]
        public virtual string FamilyName { get; set; }

        public virtual string Identifier { get; set; }

        [DataType(DataType.PhoneNumber)] public virtual string Sms { get; set; }

        [DataType(DataType.PhoneNumber)] public virtual string Phone { get; set; }

        public virtual Demographics Demographics { get; set; }

        public virtual ICollection<UserAgent> Agents { get; } = new HashSet<UserAgent>();

        public virtual ICollection<UserGrade> Grades { get; } = new HashSet<UserGrade>();

        public virtual ICollection<UserIdentifier> Ids { get; } = new HashSet<UserIdentifier>();

        public virtual ICollection<UserOrg> Orgs { get; } = new HashSet<UserOrg>();

        public virtual ICollection<Enrollment> Enrollments { get; } = new HashSet<Enrollment>();

        // students only
        public virtual ICollection<Result> Results { get; } = new HashSet<Result>();

        #region Base Object

        public virtual MetadataCollection MetadataCollection { get; set; }

        public virtual int? MetadataCollectionId { get; internal set; }

        public virtual Status Status { get; internal set; }

        public virtual DateTime Modified { get; internal set; }

        #endregion
    }
}