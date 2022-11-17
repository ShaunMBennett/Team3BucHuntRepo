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
    public class PhoneNumberService : IPhoneNumbersService
    {
        private readonly IDapperService _dapperService;
        public PhoneNumberService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(PhoneNumber pN)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PhoneNumber", pN.phoneNumber, DbType.String);
            var numID = Task.FromResult
               (_dapperService.Insert<int>("[dbo].[spAddPhoneNumber]",
               dbPara, commandType: CommandType.StoredProcedure));
            return numID;
        }
        public Task<PhoneNumber> GetByID(int id)
        {
            var phoneNum = Task.FromResult
               (_dapperService.Get<PhoneNumber>
               ($"select * from [PhoneNumbers] where UserID = {id}", null,
               commandType: CommandType.Text));
            return phoneNum;
        }
        public Task<int> Delete(int id)
        {
            var deletePhoneNumber = Task.FromResult
               (_dapperService.Execute
               ($"Delete [PhoneNumbers] where UserID = {id}", null,
               commandType: CommandType.Text));
            return deletePhoneNumber;
        }
        public Task<int> Count(string search)
        {
            var totPhoneNumber = Task.FromResult(_dapperService.Get<int>
               ($"select COUNT(*) from [PhoneNumbers] WHERE PhoneNumber like '%{search}%'", null, commandType: CommandType.Text));
            return totPhoneNumber;
        }
        public Task<List<PhoneNumber>> ListAll(int skip, int take,
           string orderBy, string direction = "DESC", string search = "")
        {
            var publishers = Task.FromResult
               (_dapperService.GetAll<PhoneNumber>
               ($"SELECT * FROM [PhoneNumbers] WHERE PhoneNumber like '%{search}%' ORDER BY { orderBy} { direction} OFFSET { skip} ROWS FETCH NEXT { take} ROWS ONLY; ", null, commandType: CommandType.Text));
           return publishers;
        }
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