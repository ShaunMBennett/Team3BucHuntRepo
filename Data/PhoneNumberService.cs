using team3.Interfaces;
using team3.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace BookApp.Data
{
    /// <summary>
    /// Isaiah Jayne
    /// This class is the implementation of the IPhoneNumberService interface
    /// Acceses the PhoneNumber Table of the database
    /// </summary>
    public class PhoneNumberService : IPhoneNumbersService
    {
        private readonly IDapperService _dapperService;
        /// <summary>
        /// Isaiah Jayne
        /// Constructor for this class
        /// </summary>
        /// <param name="dapperService"></param>
        public PhoneNumberService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }

        /// <summary>
        /// Isaiah Jayne
        /// Creates a new PhoneNumber row in the table based on the PhoneNumber entity given
        /// </summary>
        /// <param name="pN"></param>
        /// <returns></returns>
        public Task<int> Create(PhoneNumber pN)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PhoneNumber", pN.phoneNumber, DbType.String);
            var numID = Task.FromResult
               (_dapperService.Insert<int>("[dbo].[spAddPhoneNumber]",
               dbPara, commandType: CommandType.StoredProcedure));
            return numID;
        }
        /// <summary>
        /// Isaiah Jayne
        /// Retrieves a row from the Phone Number table whose ID matches the id given
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<PhoneNumber> GetByID(int id)
        {
            var phoneNum = Task.FromResult
               (_dapperService.Get<PhoneNumber>
               ($"select * from [PhoneNumbers] where UserID = {id}", null,
               commandType: CommandType.Text));
            return phoneNum;
        }
        /// <summary>
        /// Isaiah Jayne
        /// Deletes a row from the Phone Number table whose ID matches the ID given
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<int> Delete(int id)
        {
            var deletePhoneNumber = Task.FromResult
               (_dapperService.Execute
               ($"Delete [PhoneNumbers] where UserID = {id}", null,
               commandType: CommandType.Text));
            return deletePhoneNumber;
        }
        /// <summary>
        /// Isaiah Jayne
        /// Counts the number of rows in the PhoneNumber table whose phone number strings matches the given string
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public Task<int> Count(string search)
        {
            var totPhoneNumber = Task.FromResult(_dapperService.Get<int>
               ($"select COUNT(*) from [PhoneNumbers] WHERE PhoneNumber like '%{search}%'", null, commandType: CommandType.Text));
            return totPhoneNumber;
        }
        /// <summary>
        /// Isaiah Jayne
        /// Grabs all the rows from the phone number table
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <param name="orderBy"></param>
        /// <param name="direction"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public Task<List<PhoneNumber>> ListAll(int skip, int take,
           string orderBy, string direction = "DESC", string search = "")
        {
            var publishers = Task.FromResult
               (_dapperService.GetAll<PhoneNumber>
               ($"SELECT * FROM [PhoneNumbers] WHERE PhoneNumber like '%{search}%' ORDER BY { orderBy} { direction} OFFSET { skip} ROWS FETCH NEXT { take} ROWS ONLY; ", null, commandType: CommandType.Text));
           return publishers;
        }
        /// <summary>
        /// Updates a row in the table based on the PhoneNumber class given
        /// </summary>
        /// <param name="pN"></param>
        /// <returns></returns>
        public Task<int> Update(PhoneNumber pN)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserID", pN.UserID);
            dbPara.Add("PhoneNumber", pN.phoneNumber, DbType.String);
            var updatePhoneNumber = Task.FromResult
               (_dapperService.Update<int>("[dbo].[spUpdatePhoneNumber]",
               dbPara, commandType: CommandType.StoredProcedure));
            return updatePhoneNumber;
        }
    }
}