// File:    BusinessHoursFileRepository.cs
// Created: Saturday, May 2, 2020 5:16:42 PM
// Purpose: Definition of Class BusinessHoursFileRepository

using Model.BusinessHours;
using Model.Users;
using System;
using System.Collections.Generic;

namespace Repository.BusinessHoursRepo
{
    public class BusinessHoursFileRepository : BusinessHoursRepository
    {
        private void OpenFile()
        {
            throw new NotImplementedException();
        }

        private void CloseFile()
        {
            throw new NotImplementedException();
        }

        private string filePath;

        /// Metoda koja za prosledjene doktore ponovo vraca osvezen prikaz njihovog stanja radnog kalendara u skladistu podataka.
        public BusinessHoursModel GetUpdatedBusinessHours(List<Doctor> doctors)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(BusinessHoursModel entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int identificator)
        {
            throw new NotImplementedException();
        }

        public bool ExistsById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessHoursModel> FindAll()
        {
            throw new NotImplementedException();
        }

        public BusinessHoursModel FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(BusinessHoursModel entity)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<BusinessHoursModel> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessHoursModel> FindAllById(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }
    }
}