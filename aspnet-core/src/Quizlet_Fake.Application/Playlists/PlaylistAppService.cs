using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace Quizlet_Fake.Playlists
{
    public class PlaylistAppService : CrudAppService<
           Playlist, //The Book entity
           PlaylistDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdatePlaylistDto>, //Used to create/update a book
       IPlaylistAppService //implement the IBookAppService
    {
        public PlaylistAppService(IRepository<Playlist, Guid> repository, ICurrentUser currentUser)
            : base(repository)
        {

            this._repository = repository;
            this._currentUser = currentUser;
        }
        private readonly IRepository<Playlist, Guid> _repository;
        private readonly ICurrentUser _currentUser;
        public override Task<PlaylistDto> CreateAsync(CreateUpdatePlaylistDto input)
        {
            input.user_id =(Guid) _currentUser.Id;
            return base.CreateAsync(input);
        }
        public List<Playlist> getlist ()
        {
            List<Playlist> course = _repository.Where(p => p.user_id == _currentUser.Id).ToList();
            return course;
        }
    }
    
    
}
