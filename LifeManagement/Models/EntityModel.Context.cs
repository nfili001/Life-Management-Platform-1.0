﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SeniorDBEntities : DbContext
    {
        public SeniorDBEntities()
            : base("name=SeniorDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<Sprint> Sprints { get; set; }
        public virtual DbSet<Progress> Progresses { get; set; }
        public virtual DbSet<SprintActivities> SprintActivities { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<CoachReview> CoachReviews { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Forum> Forum { get; set; }
        public virtual DbSet<Conversation> Conversations { get; set; }
        public virtual DbSet<ForumFile> ForumFiles { get; set; }
    }
}
