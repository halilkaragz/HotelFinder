using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelFinderEntities;

namespace HotelFinderDataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAlllHotels();
        Hotel GetHotelById(int Id);

        Hotel CreateHotel(Hotel hotel);

        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int Id);
    }
}
