using AutoMapper;
using Quizlet_Fake.Songs;
using Quizlet_Fake.Albums;
using Quizlet_Fake.AuthorSingers;
using Quizlet_Fake.Playlists;
using Quizlet_Fake.Reports;
using Quizlet_Fake.Tags;
namespace Quizlet_Fake
{
    public class Quizlet_FakeApplicationAutoMapperProfile : Profile
    {
        public Quizlet_FakeApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Song, SongDto>();
            CreateMap<CreateUpdateSongDto, Song>();

            CreateMap<Lyric, LyricDto>();
            CreateMap<CreateUpdateLyricDto, Lyric>();


            CreateMap<Album, AlbumDto>();
            CreateMap<CreateUpdateAlbumDto, Album>();
            CreateMap<Author, AuthorDto>();
            CreateMap<CreateUpdateAuthorDto, Author>();
            CreateMap<Singer, SingerDto>();
            CreateMap<CreateUpdateSingerDto, Singer>();
            CreateMap<Playlist, PlaylistDto>();
            CreateMap<CreateUpdatePlaylistDto, Playlist>();
            CreateMap<Report, ReportDto>();
            CreateMap<CreateUpdateReportDto, Report>();
            CreateMap<Tag, TagDto>();
            CreateMap<CreateUpdateTagDto, Tag>();
            CreateMap<SongTag, SongTagDto>();
            CreateMap<CreateUpdateSongTagDto, SongTag>();
           

        }
    }
    
}
