using Quizlet_Fake.AuthorSingers;
using Quizlet_Fake.Users;
using System;
using System.Linq;

using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.DependencyInjection;
using Quizlet_Fake.EntityFrameworkCore;
using Quizlet_Fake.Tags;
using Quizlet_Fake.Reports;
using Volo.Abp.Users;
using Quizlet_Fake.Playlists;

namespace Quizlet_Fake.Songs
{
    public class SongAppService :
       CrudAppService<
           Song, //The Book entity
           SongDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateSongDto>, //Used to create/update a book
       ISongAppService //implement the IBookAppService
    {
        public SongAppService(IRepository<Song, Guid> repository, IRepository<Author, Guid> authores,
            IRepository <AppUser,Guid> userreos,
            IRepository<Singer, Guid> singer,
            IRepository<SongbySinger, Guid> songsinger,
            IRepository<Tag, Guid> tag,
            IRepository<SongTag, Guid> songtag,
            IRepository<Report, Guid> report,
            IRepository<AppUser,Guid> user,
            ICurrentUser currentUser,
            IRepository<Playlist, Guid> playlist,
            IRepository<Include, Guid> inclus
            )
            : base(repository)
        {
           this._repository = repository;
            this._userrepo = userreos;
            this._author = authores;
            this._singer = singer;
            this._songsinger = songsinger;
            this._tag = tag;
            this._songtag = songtag;
            this._report = report;
            this._user = user;
            this._currentUser = currentUser;
            this._playlist = playlist;
            this._inclus = inclus;

        }
       private readonly IRepository<Song, Guid> _repository;
         private readonly IRepository<AppUser, Guid> _userrepo;
        private readonly IRepository<Author, Guid> _author;
        private readonly IRepository<Singer, Guid> _singer;
        private readonly IRepository<SongbySinger, Guid> _songsinger;
        private readonly IRepository<Tag, Guid> _tag;
        private readonly IRepository<SongTag, Guid> _songtag;
        private readonly IRepository<Report, Guid> _report;
        private readonly IRepository<AppUser, Guid> _user;
        private readonly ICurrentUser _currentUser;
        private readonly IRepository<Playlist, Guid> _playlist;
        private readonly IRepository<Include, Guid> _inclus;

        public async Task<List<SongDto>> SongListByPlaylist( int limitfrom, Guid idplaylist)
        {
            await CheckGetListPolicyAsync();


            var query = from playlist in _playlist
                        join include in _inclus on playlist.Id equals include.playlist_id
                        join song in _repository on include.song_id equals song.Id
                        where playlist.user_id == _currentUser.Id && playlist.Id == idplaylist
                        select song;

            query = query.Skip(limitfrom).Take(10);
            var queryResult = await AsyncExecuter.ToListAsync(query);


            var DTos = queryResult.Select(x =>
            {
                var dto = ObjectMapper.Map<Song, SongDto>(x);

               
                return dto;
            }).ToList();


            return new List<SongDto>(DTos);
        }

        public async Task<List<ReportDto>> Gelistreport (Guid idsong )
        {
            await CheckGetListPolicyAsync();
            var query = from report in _report
                       join user in _user on report.CreatorId equals user.Id
                       where report.song_id == idsong
                       select new { report, user };
            
            query = query.Skip(0).Take(10);
            var queryResult = await AsyncExecuter.ToListAsync(query);
            var DTos = queryResult.Select(x =>
            {
                var dto = ObjectMapper.Map<Report, ReportDto>(x.report);

                dto.username = x.user.Name;
                return dto;
            }).ToList();

            return new List<ReportDto>(DTos);

        }
        public async Task<List<SongDto>> SearchbyTag(Guid tagg, int limitfrom)
        {
            await CheckGetListPolicyAsync();
            /*
            var query = from song in _repository
                        join songsinger in _songsinger on song.Id equals songsinger.song_id
                        join singer in _singer on songsinger.singer_id equals singer.Id 
                        where singer.name.StartsWith(singerr)
                        select new { song, singer };
            */

            var query =
                        from songtag in _songtag
                        
                        join song in _repository on songtag.song_id equals song.Id
                        join author in _author on song.author_id equals author.Id
                        join singer in _singer on song.singer_id equals singer.Id
                        where songtag.tag_id == tagg
                        select new { song, singer, author ,songtag};

            query = query.Skip(limitfrom).Take(10);
            var queryResult = await AsyncExecuter.ToListAsync(query);


            var DTos = queryResult.Select(x =>
            {
                var dto = ObjectMapper.Map<Song, SongDto>(x.song);
                dto.authorname = x.author.name;
                dto.singername = x.singer.name;
                dto.views = x.song.views;

                return dto;
            }).ToList();


            return new List<SongDto>(DTos);
        }
        

        public async Task<List<SongDto>> SongListBySinger(string text, int limitfrom)
        {
            await CheckGetListPolicyAsync();
            /*
            var query = from song in _repository
                        join songsinger in _songsinger on song.Id equals songsinger.song_id
                        join singer in _singer on songsinger.singer_id equals singer.Id 
                        where singer.name.StartsWith(singerr)
                        select new { song, singer };
            */

            
            var query = from song in _repository
                        join author in _author on song.author_id equals author.Id
                        join singerr in _singer on song.singer_id equals singerr.Id
                        where singerr.name.StartsWith(text)
                        select new { song, author, singerr };
            query = query.Skip(limitfrom).Take(10);
            var queryResult = await AsyncExecuter.ToListAsync(query);


            var DTos = queryResult.Select(x =>
            {
                var dto = ObjectMapper.Map<Song, SongDto>(x.song);
                dto.authorname = x.author.name;
                dto.singername = x.singerr.name;
                dto.views = x.song.views;
                return dto;
            }).ToList();


            return new List<SongDto>(DTos);
        }
        public async Task<List<SongDto>> SonglistByAuthor ( string authot, int limitfrom )
        {
            await CheckGetListPolicyAsync();
            var query = from song in _repository
                        join author in _author on song.author_id equals author.Id
                        join singerr in _singer on song.singer_id equals singerr.Id
                        where author.name.StartsWith(authot)
                        select new { song,author,singerr};
            query = query.Skip(limitfrom).Take(10);
            var queryResult = await AsyncExecuter.ToListAsync(query);


            var DTos = queryResult.Select(x =>
            {
                var dto = ObjectMapper.Map<Song, SongDto>(x.song);
                dto.singername = x.singerr.name;
                dto.authorname = x.author.name;
                dto.views = x.song.views;
                return dto;
            }).ToList();


            return new List<SongDto>(DTos);
        }
        public async Task<List<SongDto>> SOngSearchbyname(string key,int limitfrom)
        {
            await CheckGetListPolicyAsync();
            /*
            var query = from song in _repository
                        join songsinger in _songsinger on song.Id equals songsinger.song_id
                        join singer in _singer on songsinger.singer_id equals singer.Id 
                        where singer.name.StartsWith(singerr)
                        select new { song, singer };
            */

            var query = from singer in _singer

                        join song in _repository on singer.Id equals song.singer_id
                        join author in _author on song.author_id equals author.Id
                        where song.name.StartsWith(key)
                        select new { song, singer,author };

            query = query.Skip(limitfrom).Take(10);
            var queryResult = await AsyncExecuter.ToListAsync(query);


            var DTos = queryResult.Select(x =>
            {
                var dto = ObjectMapper.Map<Song, SongDto>(x.song);
                dto.authorname = x.author.name;
                dto.singername = x.singer.name;
                dto.views = x.song.views;
                return dto;
            }).ToList();


            return new List<SongDto>(DTos);
        }
        public async Task<List<SongDto>> ListSong( int limitfrom)
        {
            await CheckGetListPolicyAsync();
            /*
            var query = from song in _repository
                        join songsinger in _songsinger on song.Id equals songsinger.song_id
                        join singer in _singer on songsinger.singer_id equals singer.Id 
                        where singer.name.StartsWith(singerr)
                        select new { song, singer };
            */

            var query = from singer in _singer
                        
                        join song in _repository on singer.Id equals song.singer_id
                        join author in _author on song.author_id equals author.Id
                        select new { song, singer,author };

            query = query.Skip(limitfrom).Take(10);
            var queryResult = await AsyncExecuter.ToListAsync(query);


            var DTos = queryResult.Select(x =>
            {
                var dto = ObjectMapper.Map<Song, SongDto>(x.song);
                dto.authorname = x.author.name;
                dto.singername = x.singer.name;
                dto.views = x.song.views;
                return dto;
            }).ToList();


            return new List<SongDto>(DTos);
        }

       

        public async Task<List<SongDto>> chart(int limitfrom)
        {
            await CheckGetListPolicyAsync();
            /*
            var query = from song in _repository
                        join songsinger in _songsinger on song.Id equals songsinger.song_id
                        join singer in _singer on songsinger.singer_id equals singer.Id 
                        where singer.name.StartsWith(singerr)
                        select new { song, singer };
            */

            var query = from singer in _singer

                        join song in _repository on singer.Id equals song.singer_id
                        join author in _author on song.author_id equals author.Id
                        orderby song.views descending
                        select new { song, singer, author }; 

            query = query.Skip(limitfrom).Take(10);
            query.OrderByDescending(c => c.song.views);
            var queryResult = await AsyncExecuter.ToListAsync(query);


            var DTos = queryResult.Select(x =>
            {
                var dto = ObjectMapper.Map<Song, SongDto>(x.song);
                dto.authorname = x.author.name;
                dto.singername = x.singer.name;
                dto.views = x.song.views;
                return dto;
            }).ToList();


            return new List<SongDto>(DTos);
        }
    }
}
