// File:    CheckupRepository.cs
// Created: Saturday, May 2, 2020 7:05:49 PM
// Purpose: Definition of Interface CheckupRepository

using Model.Calendar;
using Repository.GenericCRUD;

namespace Repository.TermRepo
{
   public interface CheckupRepository : GenericInterfaceCRUDDao<Checkup, int>
   {

   }
}