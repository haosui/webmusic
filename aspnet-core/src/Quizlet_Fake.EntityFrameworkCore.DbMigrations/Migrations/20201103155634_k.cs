using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Quizlet_Fake.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "singer_id",
                table: "AppSongs");

            migrationBuilder.CreateIndex(
                name: "IX_AppSongTags_song_id",
                table: "AppSongTags",
                column: "song_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppSongTags_tag_id",
                table: "AppSongTags",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppSongs_album_id",
                table: "AppSongs",
                column: "album_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppSongs_author_id",
                table: "AppSongs",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppSongbySingers_singer_id",
                table: "AppSongbySingers",
                column: "singer_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppSongbySingers_song_id",
                table: "AppSongbySingers",
                column: "song_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppReports_song_id",
                table: "AppReports",
                column: "song_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppLyrics_song_id",
                table: "AppLyrics",
                column: "song_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppIncludes_playlist_id",
                table: "AppIncludes",
                column: "playlist_id");

            migrationBuilder.CreateIndex(
                name: "IX_AppIncludes_song_id",
                table: "AppIncludes",
                column: "song_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppIncludes_AppPlaylists_playlist_id",
                table: "AppIncludes",
                column: "playlist_id",
                principalTable: "AppPlaylists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppIncludes_AppSongs_song_id",
                table: "AppIncludes",
                column: "song_id",
                principalTable: "AppSongs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLyrics_AppSongs_song_id",
                table: "AppLyrics",
                column: "song_id",
                principalTable: "AppSongs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppReports_AppSongs_song_id",
                table: "AppReports",
                column: "song_id",
                principalTable: "AppSongs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSongbySingers_AppSingers_singer_id",
                table: "AppSongbySingers",
                column: "singer_id",
                principalTable: "AppSingers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSongbySingers_AppSongs_song_id",
                table: "AppSongbySingers",
                column: "song_id",
                principalTable: "AppSongs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSongs_AppAlbums_album_id",
                table: "AppSongs",
                column: "album_id",
                principalTable: "AppAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSongs_AppAuthors_author_id",
                table: "AppSongs",
                column: "author_id",
                principalTable: "AppAuthors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSongTags_AppSongs_song_id",
                table: "AppSongTags",
                column: "song_id",
                principalTable: "AppSongs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSongTags_AppTags_tag_id",
                table: "AppSongTags",
                column: "tag_id",
                principalTable: "AppTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppIncludes_AppPlaylists_playlist_id",
                table: "AppIncludes");

            migrationBuilder.DropForeignKey(
                name: "FK_AppIncludes_AppSongs_song_id",
                table: "AppIncludes");

            migrationBuilder.DropForeignKey(
                name: "FK_AppLyrics_AppSongs_song_id",
                table: "AppLyrics");

            migrationBuilder.DropForeignKey(
                name: "FK_AppReports_AppSongs_song_id",
                table: "AppReports");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSongbySingers_AppSingers_singer_id",
                table: "AppSongbySingers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSongbySingers_AppSongs_song_id",
                table: "AppSongbySingers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSongs_AppAlbums_album_id",
                table: "AppSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSongs_AppAuthors_author_id",
                table: "AppSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSongTags_AppSongs_song_id",
                table: "AppSongTags");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSongTags_AppTags_tag_id",
                table: "AppSongTags");

            migrationBuilder.DropIndex(
                name: "IX_AppSongTags_song_id",
                table: "AppSongTags");

            migrationBuilder.DropIndex(
                name: "IX_AppSongTags_tag_id",
                table: "AppSongTags");

            migrationBuilder.DropIndex(
                name: "IX_AppSongs_album_id",
                table: "AppSongs");

            migrationBuilder.DropIndex(
                name: "IX_AppSongs_author_id",
                table: "AppSongs");

            migrationBuilder.DropIndex(
                name: "IX_AppSongbySingers_singer_id",
                table: "AppSongbySingers");

            migrationBuilder.DropIndex(
                name: "IX_AppSongbySingers_song_id",
                table: "AppSongbySingers");

            migrationBuilder.DropIndex(
                name: "IX_AppReports_song_id",
                table: "AppReports");

            migrationBuilder.DropIndex(
                name: "IX_AppLyrics_song_id",
                table: "AppLyrics");

            migrationBuilder.DropIndex(
                name: "IX_AppIncludes_playlist_id",
                table: "AppIncludes");

            migrationBuilder.DropIndex(
                name: "IX_AppIncludes_song_id",
                table: "AppIncludes");

            migrationBuilder.AddColumn<Guid>(
                name: "singer_id",
                table: "AppSongs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
