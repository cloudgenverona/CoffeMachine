using System;
using Xunit;

namespace Core.UnitTest
{
    public class DrinkMakerTest
    {
        [Fact]
        public void DrinkMakerTest_1_Tea_1_Sugar_1_Stick()
        {
            DrinkMaker d = new DrinkMaker("T:1:0");
            Assert.Equal(DrinkType.Tea, d.DrinkType);
            Assert.Equal(1, d.Sugar);
            Assert.True(d.IsStickPresent);
        }

        [Fact]
        public void DrinkMakerTest_1_Chocolate_1_Sugar_1_Stick()
        {
            DrinkMaker d = new DrinkMaker("H::");
            Assert.Equal(DrinkType.Chocolate, d.DrinkType);
            Assert.Equal(0, d.Sugar);
            Assert.False(d.IsStickPresent);
        }

        [Fact]
        public void DrinkMakerTest_1_Coffe_2_Sugar_1_Stick()
        {
            DrinkMaker d = new DrinkMaker("C:2:0");
            Assert.Equal(DrinkType.Coffe, d.DrinkType);
            Assert.Equal(2, d.Sugar);
            Assert.True(d.IsStickPresent);
        }

        [Fact]
        public void DrinkMakerTest_M_Message()
        {
            DrinkMaker d = new DrinkMaker("M:message-content");
            Assert.Equal(DrinkType.Service, d.DrinkType);
            Assert.Equal(0, d.Sugar);
            Assert.False(d.IsStickPresent);
        }
    }
}
