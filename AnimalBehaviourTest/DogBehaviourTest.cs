using AnimalBehaviour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AnimalBehaviourTest
{
    public class DogBehaviourTest
    {
        DogBehaviour dogBehaviour;

        [Fact]
        public void DogSpeakBasedOnBreedisWolfShouldbeWoow()
        {
            //Arrange
            string dogbreed = "Wolf";
            string expected = "Woow";
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogSpeakBasedonBreed(dogbreed);
            //Assert
            Assert.Equal(expected, actualresult);
        }
        [Fact]
        public void DogSpeakBasedOnBreedisBullDogShouldbeBow()
        {
            //Arrange
            string dogbreed = "BullDog";
            string expected = "Bow";
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogSpeakBasedonBreed(dogbreed);
            //Assert
            Assert.Equal(expected, actualresult);
        }
        [Fact]
        public void DogSpeakBasedOnBreedisWolfShouldbeNull()
        {
            //Arrange
            string dogbreed = "German Shepherd";
            string expected = null;
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogSpeakBasedonBreed(dogbreed);
            //Assert
            Assert.Equal(expected, actualresult);
        }

        [Fact]
        public void DogSpeakBasedOnNameRexShouldBeFoo()
        {
            //Arrange
            string dogName = "Rex";
            string expected = "Foo";
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogSpeakBasedonName(dogName);
            //Assert
            Assert.Equal(expected, actualresult);
        }
        [Fact]
        public void DogSpeakBasedOnNameRockyShouldbeMoo()
        {
            //Arrange
            string dogName = "Rocky";
            string expected = "Moo";
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogSpeakBasedonName(dogName);
            //Assert
            Assert.Equal(expected, actualresult);
        }
        [Fact]
        public void DogSpeakBasedOnNameRockyShouldbeNull()
        {
            //Arrange
            string dogName = "Lucky";
            string expected = null;
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogSpeakBasedonBreed(dogName);
            //Assert
            Assert.Equal(expected, actualresult);
        }
        [Fact]
        public void DogSmartCheckbasedTrained()
        {
            //Arrange
            bool trained = true;
            string expected = "Trained Dog";
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogSmartChekBasedonTrained(trained);
            //Assert
            Assert.Equal(expected, actualresult);
        }
        [Fact]
        public void DogdomesticCheckBasedTrained()
        {
            //Arrange
            bool trained = false;
            string expected = "Domenstic Dog";
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogSmartChekBasedonTrained(trained);
            //Assert
            Assert.Equal(expected, actualresult);
        }
        [Fact]
        public void DogPrizeCheckForBreedasGermanShepherdColorasGreyPrizeShouldDoller800()
        {
            //Arrange
            string  breed = "German Shepherd";
            string color = "Grey";
            string expected = "$800";
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogPrizeBasedonBreedandColor(breed, color);
            //Assert
            Assert.Equal(expected, actualresult);
        }
        [Fact]
        public void DogPrizeCheckForBreedasGermanShepherdColorasBlackPrizeShouldDoller1000()
        {
            //Arrange
            string breed = "German Shepherd";
            string color = "Black";
            string expected = "$1000";
            //Act
            dogBehaviour = new DogBehaviour();
            string actualresult = dogBehaviour.GetDogPrizeBasedonBreedandColor(breed, color);
            //Assert
            Assert.Equal(expected, actualresult);
        }
    }
}
