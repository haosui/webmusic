using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Quizlet_Fake.Albums;
using Quizlet_Fake.AuthorSingers;
using Quizlet_Fake.Playlists;
using Quizlet_Fake.Reports;
using Quizlet_Fake.Songs;
using Quizlet_Fake.Tags;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Quizlet_Fake.EntityFrameworkCore
{
    public static class Quizlet_FakeDbContextModelCreatingExtensions
    {
        public static void ConfigureQuizlet_Fake(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
            builder.Entity<Album>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Albums",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                
            });
            builder.Entity<Author>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Authors",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });
            builder.Entity<Singer>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Singers",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });
            builder.Entity<SongbySinger>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "SongbySingers",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.HasOne<Song>().WithMany().HasForeignKey(x => x.song_id).IsRequired();
                b.HasOne<Singer>().WithMany().HasForeignKey(x => x.singer_id).IsRequired();

            });
            builder.Entity<Include>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Includes",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.HasOne<Song>().WithMany().HasForeignKey(x => x.song_id).IsRequired();
                b.HasOne<Playlist>().WithMany().HasForeignKey(x => x.playlist_id).IsRequired();

            });
            builder.Entity<Playlist>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Playlists",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });
            builder.Entity<Report>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Reports",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.HasOne<Song>().WithMany().HasForeignKey(x => x.song_id).IsRequired();

            });
            builder.Entity<Lyric>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Lyrics",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.HasOne<Song>().WithMany().HasForeignKey(x => x.song_id).IsRequired();

            });
            builder.Entity<Song>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Songs",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

                b.HasOne<Author>().WithMany().HasForeignKey(x => x.author_id).IsRequired();
                b.HasOne<Album>().WithMany().HasForeignKey(x => x.album_id).IsRequired();

            });
            builder.Entity<SongTag>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "SongTags",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

                b.HasOne<Song>().WithMany().HasForeignKey(x => x.song_id).IsRequired();
                b.HasOne<Tag>().WithMany().HasForeignKey(x => x.tag_id).IsRequired();


            });
            builder.Entity<Tag>(b =>
            {
                b.ToTable(Quizlet_FakeConsts.DbTablePrefix + "Tags",
                          Quizlet_FakeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });
            
        }
    }
}