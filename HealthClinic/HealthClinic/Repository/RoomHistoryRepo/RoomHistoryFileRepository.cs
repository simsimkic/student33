// File:    RoomHistoryFileRepository.cs
// Created: Saturday, May 2, 2020 5:16:42 PM
// Purpose: Definition of Class RoomHistoryFileRepository

using Model.Patient;
using System;
using System.Collections.Generic;

namespace Repository.RoomHistoryRepo
{
    public class RoomHistoryFileRepository : RoomHistoryRepository
    {
        private void OpenFIle()
        {
            throw new NotImplementedException();
        }

        private void CloseFIle()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(RoomsHistory entity)
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

        public IEnumerable<RoomsHistory> FindAll()
        {
            throw new NotImplementedException();
        }

        public RoomsHistory FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(RoomsHistory entity)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<RoomsHistory> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoomsHistory> FindAllById(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

        private string filePath;

    }
}