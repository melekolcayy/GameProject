using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Save(Player player)
        {
            if (_playerCheckService.CheckPlayerRealPerson(player))
            {
                Console.WriteLine("Player is saved :" + "\nId No : " + player.Id + "\nFirstname : " + player.FirstName +
                    "\nLastname : " + player.LastName + "\nIdentity No : " + player.NationalityId +
                    "\nDate Of Birth : " + player.DateOfBirth);
            }
            else
            {
                throw new Exception("Invalid User! please check your information! ");
            }
            Console.WriteLine("******************************************");
        }


        public void Update(Player player)
        {
            Console.WriteLine("Player is updated : " + "\nId No : " + player.Id);
            Console.WriteLine("*******************************************");
        }


        public void Delete(Player player)
        {
            Console.WriteLine("Player is deleted : " + "\nId No : " + player.Id);
            Console.WriteLine("*******************************************");
        }
    }
}
