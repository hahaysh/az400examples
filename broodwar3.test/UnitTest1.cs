using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace broodwar3.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void ReturnReturnTest()
        {
            // arrange
            broodwar3.lib.GoDoWa goDowa = new broodwar3.lib.GoDoWa();
            string strTemp = string.Empty;
            // act
            strTemp = goDowa.ReturnReturn(new string[] { "저그와 ", "테란" });
            // assert
            if (string.IsNullOrEmpty(strTemp))
            {
            Assert.Fail();
            }
        }
    }
}
