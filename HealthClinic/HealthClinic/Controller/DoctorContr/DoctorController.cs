// File:    DoctorController.cs
// Created: Sunday, May 3, 2020 11:47:00 AM
// Purpose: Definition of Class DoctorController

using Model.Calendar;
using Model.MedicalRecord;
using Model.Medicine;
using Model.Users;
using Service.UserServ;
using System;
using System.Collections.Generic;

namespace Controller.DoctorContr
{
    public class DoctorController
    {
        public DoctorService doctorService = new DoctorService();

        public List<Doctor> GetAllDoctors()
        {
            return doctorService.GetAllDoctors();
        }

        public void SaveUpdatedDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Doctor DoctorLogin(string username, string password)
        {
            return doctorService.DoctorLogin(username, password);
        }

        public bool isEmailTaken(string email)
        {
            return doctorService.isEmailTaken(email);
        }

        public void AddDoctor(Doctor doctor)
        {
            doctorService.AddDoctor(doctor);
        }

        public Doctor FindById(int id)
        {
            return doctorService.FindById(id);
        }

        public List<Doctor> GetAllSpecialistsBySpecialty(SpecialtyType specialtyType)
        {
            return doctorService.GetAllSpecialistsBySpecialty(specialtyType);
        }
        public bool IsDoctorFree(Doctor doctor, DateTime dateStart, DateTime dateEnd)
        {
            return doctorService.IsDoctorFree(doctor.Id, dateStart, dateEnd);
        }


    }
}