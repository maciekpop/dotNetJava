using dotNetProjekt;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
       
        [Test]
        public void nameTest()
        {
            //Arrange
            string name;
            //Act
            DataForTest.setTestWorker();
            name = DataForTest.giveName();
            //Assert

            Assert.AreEqual(name, "Jan");
        }

        [Test]
        public void surnameTest()
        {
            //Arrange
            string surname;

            //Act
            DataForTest.setTestWorker();
            surname = DataForTest.giveSurame();
            //Assert

            Assert.AreEqual(surname, "Kowalski");
        }

        
        [Test]
        public void phoneTest()
        {
            //Arrange
            int phoneNumber;

            //Act
            DataForTest.setTestWorker();
            phoneNumber = DataForTest.givePhone();
            //Assert

            Assert.AreEqual(phoneNumber, 725321843);
        }


         [Test]
         public void addressTest()
            {
            //Arrange
            string address;
            //Act
            DataForTest.setTestWorker();
            address = DataForTest.giveAddress();
            //Assert

            Assert.AreEqual(address, "Warszawa");
        }

        [Test]
        public void emailTest()
        {
            //Arrange
            string email;
            //Act
            DataForTest.setTestWorker();
            email = DataForTest.giveEmail();
            //Assert

            Assert.AreEqual(email, "jank@gmail.com");
        }

        [Test]
        public void hourSpanTest()
        {
            //Arrange
            double hourSpan;
            //Act
            DataForTest.setTestTime();
            hourSpan = DataForTest.giveHourSpan();
            //Assert

            Assert.AreEqual(hourSpan, 8.0d);
        }

        [Test]
        public void beginTimeTest()
        {
            //Arrange
            DateTime beginnigTime;
            //Act
            DataForTest.setTestTime();
            beginnigTime = DataForTest.giveBeginTime();
            //Assert

            Assert.AreEqual(beginnigTime, new DateTime(2020, 5, 10, 4, 0, 0));
        }


        [Test]
        public void endTimeTest()
        {
            //Arrange
            DateTime endTime;
            //Act
            DataForTest.setTestTime();
            endTime = DataForTest.giveEndTime();
            //Assert

            Assert.AreEqual(endTime, new DateTime(2020, 5, 10, 12, 0, 0));
        }


    }
}