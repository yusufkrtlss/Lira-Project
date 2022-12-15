using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Dto;
using CoreLayer.Results.Abstract;
using CoreLayer.Results.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FavoritesManager : IFavoritesService
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        // Constructor
        public FavoritesManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Add(FavoritesDto favoriteAddDto)
        {
            var favorite = _mapper.Map<Favorites>(favoriteAddDto);
            try
            {

                await _unitOfWork.Favorites.AddAsync(favorite);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success);
        }

        public Task<IResult> Delete(int FavoriteId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<FavoriteListDto>> GetAllAsync()
        {
            var favorite = await _unitOfWork.Favorites.GetAllAsync();

            if (favorite.Count > 0)
            {
                return new DataResult<FavoriteListDto>(ResultStatus.Success, new FavoriteListDto
                {
                    Favorites = favorite
                });
            }
            else
            {
                // Do nothing
            }
            return new DataResult<FavoriteListDto>(ResultStatus.Error, "Couldn't find any customer", new FavoriteListDto
            {
                Favorites = null
            });
        }

        public Task<IDataResult<FavoriteListDto>> GetAllByNonDeletedAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetAllCustomerCount()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetAllCustomerNonDeletedCount()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<FavoritesDto>> GetAsync(string favoriteName)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<FavoritesDto>> GetById(int FavoriteId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<FavoritesDto>> GetCustomerUpdateDtoByCustomerId(int FavoriteId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(FavoritesDto favoriteUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
