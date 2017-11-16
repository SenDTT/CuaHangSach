using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CuaHangSach.Tests
{
    [TestClass]
    public class HoaDonBanObjTests
    {
        private HoaDonBanObj HDBobj;

        [TestInitialize]
        public void SetUp()
        {
            this.HDBobj = new HoaDonBanObj("11", "2017-12-03", 1, "17701", 0);
        }


        [TestMethod]
        public void TestHDBObj1()
        {
            Assert.AreEqual(HDBobj.MaHDB, "11");
        }

        [TestMethod]
        public void TestHDBObj2()
        {
            Assert.AreEqual(HDBobj.NgayBan, "2017-12-03");
        }

        [TestMethod]
        public void TestHDBObj3()
        {
            Assert.AreEqual(HDBobj.MaKH, 1);
        }

        [TestMethod]
        public void TestHDBObj4()
        {
            Assert.AreEqual(HDBobj.MaNV, "17701");
        }

        [TestMethod]
        public void TestHDBObj5()
        {
            Assert.AreEqual(HDBobj.Thue, 0);
        }

        [TestMethod]
        public void TestHDBObj6()
        {
            Assert.IsNotNull(HDBobj.MaHDB, "Mã hóa đơn bán không được null");
        }

    }
}
