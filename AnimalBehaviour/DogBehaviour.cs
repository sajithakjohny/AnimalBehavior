using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBehaviour
{
    public class DogBehaviour
    {
        public DogBehaviour()
        {

        }
        public string GetDogSpeakBasedonBreed(string breed)
        {
            if (breed == "Wolf")
            {
                return "Woow";
            }
            else if (breed == "BullDog")
            {
                return "Bow";
            }
            else
            {
                return null;
            }
        }
        public string GetDogSpeakBasedonName(string name)
        {
            if (name == "Rex")
            {
                return "Foo";
            }
            else if (name == "Rocky")
            {
                return "Moo";
            }
            else
            {
                return null;
            }
        }
        public string GetDogSmartChekBasedonTrained(bool trained)
        {
            if (trained)
            {
                return "Trained Dog";
            }
            else 
            {
                return "Domenstic Dog";
            }
        }
        public string GetDogPrizeBasedonBreedandColor(string breed,string color)
        {
            if (breed == "German Shepherd" && color == "Grey")
            {
                return "$800";
            }
            else if (breed == "German Shepherd" && color == "Black")
            {
                return "$1000";
            }
            else
            {
                return "700";
            }
        }
    }
}
