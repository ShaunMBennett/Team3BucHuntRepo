﻿using team3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace team3.Interfaces
{
    /// <summary>
    /// Isaiah Jayne
    /// These are methods that are used by our solution to access the PhoneNumber Table in our database
    /// </summary>
    public interface IPhoneNumbersService
    {
        Task<int> Create(PhoneNumber pN);
        Task<int> Delete(int ID);
        Task<int> Count(string search);
        Task<int> Update(PhoneNumber pN);
        Task<PhoneNumber> GetByID(int ID);
        Task<List<PhoneNumber>> ListAll(int skip, int take,
          string orderBy, string direction, string search);
    }
}
