// File:    SecretaryFileRepositoryFactory.cs
// Created: Friday, May 29, 2020 5:47:48 PM
// Purpose: Definition of Class SecretaryFileRepositoryFactory

using System;

namespace HealthClinic.Repository.UserRepo.SecretaryRepo
{
    public class SecretaryFileRepositoryFactory : SecretaryRepositoryFactory
    {
        private SecretaryFileRepository secretaryFileRepository;

        public SecretaryRepository CreateSecretaryRepository()
        {
            if (secretaryFileRepository == null)
                secretaryFileRepository = new SecretaryFileRepository();

            return secretaryFileRepository;
        }
    }
}