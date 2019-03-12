using System;
using Xunit;

namespace Core.UnitTest
{
    public class DrinkMakerTest
    {
        [Fact]
        public void DrinkMakerTest_1_Tea_1_Sugar_1_Stick_Money_40()
        {
            DrinkMaker d = new DrinkMaker("T:1:0",40);
            Assert.Equal(DrinkType.Tea, d.DrinkType);
            Assert.Equal(1, d.Sugar);
            Assert.True(d.IsStickPresent);
        }

        [Fact]
        public void DrinkMakerTest_1_Chocolate_1_Sugar_1_Stick_Money_50()
        {
            DrinkMaker d = new DrinkMaker("H::",50);
            Assert.Equal(DrinkType.Chocolate, d.DrinkType);
            Assert.Equal(0, d.Sugar);
            Assert.False(d.IsStickPresent);
        }

        [Fact]
        public void DrinkMakerTest_1_Coffe_2_Sugar_1_Stick_Money_60()
        {
            DrinkMaker d = new DrinkMaker("C:2:0",60);
            Assert.Equal(DrinkType.Coffe, d.DrinkType);
            Assert.Equal(2, d.Sugar);
            Assert.True(d.IsStickPresent);
        }
        
        [Fact]
        public void DrinkMakerTest_M_Message()
        {
            DrinkMaker d = new DrinkMaker("M:message-content", 0);
            Assert.Equal(DrinkType.Service, d.DrinkType);
            Assert.Equal(0, d.Sugar);
            Assert.False(d.IsStickPresent);
            Assert.Equal("message-content", d.Message);
        }

        [Fact]
        public void DrinkMakerTest_1_Tea_1_Sugar_1_Stick_Money_20()
        {
            DrinkMaker d = new DrinkMaker("T:1:0",20);
            Assert.Equal(DrinkType.Service, d.DrinkType);
            Assert.Equal("Mancano 20 centesimi", d.Message);
        }


        [Fact]
        public void DrinkMakerTest_1_Chocolate_1_Sugar_1_Stick_Money_20()
        {
            DrinkMaker d = new DrinkMaker("H::", 20);
            Assert.Equal(DrinkType.Service, d.DrinkType);
            Assert.Equal("Mancano 30 centesimi", d.Message);
        }

        [Fact]
        public void DrinkMakerTest_1_Coffe_2_Sugar_1_Stick_Money_20()
        {
            DrinkMaker d = new DrinkMaker("C:2:0", 20);
            Assert.Equal(DrinkType.Service, d.DrinkType);
            Assert.Equal("Mancano 40 centesimi", d.Message);
        }


    }
}
