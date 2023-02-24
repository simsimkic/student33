// File:    MedicineFileRepositoryFactory.cs
// Created: Friday, May 29, 2020 6:01:16 PM
// Purpose: Definition of Class MedicineFileRepositoryFactory

using System;

namespace Repository.MedicineRepo
{
    public class MedicineFileRepositoryFactory : MedicineRepositoryFactory
    {
        public MedicineRepository CreateMedicineRepository()
        {
            throw new NotImplementedException();
        }
    }
}