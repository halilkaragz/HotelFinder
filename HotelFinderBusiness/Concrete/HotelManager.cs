using HotelFinderBusiness.Abstract;
using HotelFinderDataAccess.Abstract;
using HotelFinderDataAccess.Concrete;
using HotelFinderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinderBusiness.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int Id)
        {
            _hotelRepository.DeleteHotel(Id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAlllHotels();
        }

        public Hotel GetHotelById(int Id)
        {
            if (Id > 0)
            {
                return _hotelRepository.GetHotelById(Id);
            }
            throw new Exception("id can not be less than 1");
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
