using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete.Models
{
    class Target
    {


        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public bool IsDestroyed { get; protected set; }


        public int XCoordinate { get; protected set; }
        public int YCoordinate { get; protected set; }
        public int ZCoordinate { get; protected set; }

        public Target(string name, string description, bool isDestoryed, int xCoordinate, int yCoordinate, int zCoordinate)
        {
            Name = name;
            Description = description;
            this.IsDestroyed = isDestoryed;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ZCoordinate = zCoordinate;
        }

        public Target(int id, string name, string description, bool isDestroyed, int xCoordinate, int yCoordinate, int zCoordinate)
        {
            Id = id;
            Name = name;
            Description = description;
            this.IsDestroyed = isDestroyed;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ZCoordinate = zCoordinate;
        }

        public Target(string name, string description, int xCoordinate, int yCoordinate, int zCoordinate)
        {
            Name = name;
            Description = description;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ZCoordinate = zCoordinate;
        }

        public bool TryAlgo() 
        {
            int rnd = new Random().Next(1, 11);

            return (rnd < 7);
        }

        public void TryAttack() 
        {
            int rnd = new Random().Next(1,11);
            
            

            if (rnd < 7) 
            {
                IsDestroyed = true;
            }
            else 
            {
                IsDestroyed = false;
            }
        }

    }
}
