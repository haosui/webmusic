﻿using Microsoft.EntityFrameworkCore;
using Quizlet_Fake.Users;

using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using Quizlet_Fake.Albums;
using Quizlet_Fake.AuthorSingers;
using Quizlet_Fake.Playlists;
using Quizlet_Fake.Reports;
using Quizlet_Fake.Songs;
using Quizlet_Fake.Tags;

namespace Quizlet_Fake.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See Quizlet_FakeMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class Quizlet_FakeDbContext : AbpDbContext<Quizlet_FakeDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Album> Album { get; set; }

        public DbSet<Author> Author { get; set; }

        public DbSet<Singer> Singer { get; set; }

        public DbSet<SongbySinger> SongBySinger { get; set; }

        public DbSet<Playlist> Playlist { get; set; }

        public DbSet<Include> Include { get; set; }

        public DbSet<Report> Report { get; set; }

        public DbSet<Lyric> Lyric { get; set; }

        public DbSet<Song> Song { get; set; }
        public DbSet<SongTag> SongTag { get; set; }

        public DbSet<Tag> Tag { get; set; }



        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside Quizlet_FakeDbContextModelCreatingExtensions.ConfigureQuizlet_Fake
         */

        public Quizlet_FakeDbContext(DbContextOptions<Quizlet_FakeDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the Quizlet_FakeEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureQuizlet_Fake method */

            builder.ConfigureQuizlet_Fake();
        }
    }
}
