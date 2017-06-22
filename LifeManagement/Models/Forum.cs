//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LifeManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Forum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Forum()
        {
            this.Conversations = new HashSet<Conversation>();
            this.ForumFiles = new HashSet<ForumFile>();
        }
    
        public int Id { get; set; }
        public System.DateTime ForumDate { get; set; }
        public int UserId { get; set; }
        public int CoachId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conversation> Conversations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForumFile> ForumFiles { get; set; }
        public virtual User User { get; set; }
        public virtual Coach Coach { get; set; }
    }
}
