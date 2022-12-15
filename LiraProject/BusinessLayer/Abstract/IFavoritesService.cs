using BusinessLayer.Dto;
using CoreLayer.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFavoritesService
    {
        Task<IDataResult<FavoritesDto>> GetAsync(string favoriteName);
        Task<IDataResult<FavoritesDto>> GetById(int FavoriteId); // Buradaki customerId olduğu için di mi hayır hemen anltorum
        Task<IDataResult<FavoriteListDto>> GetAllAsync();
        Task<IResult> Add(FavoritesDto favoriteAddDto);
        Task<IResult> Update(FavoritesDto favoriteUpdateDto);
        Task<IResult> Delete(int FavoriteId);
        Task<IDataResult<FavoriteListDto>> GetAllByNonDeletedAsync();
        Task<int> GetAllCustomerCount();
        Task<int> GetAllCustomerNonDeletedCount();
        Task<IDataResult<FavoritesDto>> GetCustomerUpdateDtoByCustomerId(int FavoriteId);
    }
}
