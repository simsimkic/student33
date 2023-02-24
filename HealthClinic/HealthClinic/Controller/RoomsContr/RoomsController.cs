// File:    RoomsController.cs
// Created: Sunday, May 3, 2020 9:00:10 PM
// Purpose: Definition of Class RoomsController

using Model.MedicalRecord;
using Model.Rooms;
using Model.Users;
using Service.RoomServ;
using System;
using System.Collections.Generic;

namespace Controller.RoomsContr
{
    public class RoomsController
    {
        public RoomsService roomsService = new RoomsService();

        public void changeRoomInventory(Room room, InventoryType inventory)
        {
            roomsService.changeRoomInventory(room, inventory);
        }

        public void makeUpdateFor(Room room)
        {
            roomsService.makeUpdateFor(room);
        }

        public void addRoom(Room room)
        {
            roomsService.addRoom(room);
        }

        public void removeRoom(Room room)
        {
            roomsService.removeRoom(room);
        }

        public void removeRoomById(int id)
        {
            roomsService.removeRoomById(id);
        }

        public Room findByNumberOfRoom(int id)
        {
            return roomsService.findByNumberOfRoom(id);
        }

        public Room findById(int id)
        {
            return roomsService.findById(id);
        }

        public void saveAllRooms(List<Room> roomsForSave)
        {
            roomsService.saveAllRooms(roomsForSave);
        }

        public List<Room> GetAvailablePatientsRooms()
        {
            return roomsService.GetAvailablePatientsRooms();
        }

        public List<Room> GetAllOperatingRooms()
        {
            return roomsService.GetAllOperatingRooms();
        }

        public List<Room> GetAllOrdinations()
        {
            return roomsService.GetAllOrdinations();
        }

        public List<Room> GetAllRooms()
        {
            return roomsService.GetAllRooms();
        }

        public bool TransferPatient(Room newRoom)
        {
            return false;
        }

        public List<Room> GetFreeOperationRooms(DateTime start, DateTime end)
        {

            return roomsService.GetFreeOperationRooms(start, end);
        }

        public List<Room> GetFreeOrdinations(DateTime start, DateTime end)
        {
            return roomsService.GetFreeOrdinations(start, end);
        }

        public bool isRoomFree(int roomId, DateTime start, DateTime end)
        {
            return roomsService.IsRoomFree(roomId, start, end);
        }



    }
}