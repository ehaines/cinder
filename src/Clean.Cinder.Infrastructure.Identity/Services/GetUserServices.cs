using Microsoft.EntityFrameworkCore;
using Clean.Cinder.Core.DTOs;
using Clean.Cinder.Core.DTOs.Account.Requests;
using Clean.Cinder.Core.DTOs.Account.Responses;
using Clean.Cinder.Core.Interfaces.UserInterfaces;
using Clean.Cinder.Core.Wrappers;
using Clean.Cinder.Infrastructure.Identity.Contexts;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Cinder.Infrastructure.Identity.Services
{
    public class GetUserServices(IdentityContext identityContext) : IGetUserServices
    {
        public async Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model)
        {
            var skip = (model.PageNumber - 1) * model.PageSize;

            var users = identityContext.Users
                .Select(p => new UserDto()
                {
                    Name = p.Name,
                    Email = p.Email,
                    UserName = p.UserName,
                    PhoneNumber = p.PhoneNumber,
                    Id = p.Id,
                    Created = p.Created,
                });

            if (!string.IsNullOrEmpty(model.Name))
            {
                users = users.Where(p => p.Name.Contains(model.Name));
            }

            var result = new PagenationResponseDto<UserDto>(
                await users.Skip(skip).Take(model.PageSize).ToListAsync(),
                await users.CountAsync(),
                model.PageNumber, model.PageSize);

            return new PagedResponse<UserDto>(result);
        }
    }
}
