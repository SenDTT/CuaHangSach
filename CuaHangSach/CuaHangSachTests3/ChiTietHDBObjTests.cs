using Microsoft.VisualStudio.TestTools.UnitTesting;
using CuaHangSach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSach.Tests
{
    [TestClass]
    public class ChiTietHDBObjTests
    {
        private ChiTietHDBObj ctHDBobj;

        [TestInitialize]
        public void SetUp()
        {
            this.ctHDBobj = new ChiTietHDBObj("11", "CN0001", 60000, 2);
        }


        [TestMethod]
        public void TestChiTietHDBObj1()
        {
            Assert.AreEqual(ctHDBobj.MaHDB, "11");
        }

        [TestMethod]
        public void TestChiTietHDBObj2()
        {
            Assert.AreEqual(ctHDBobj.MaSach, "CN0001");
        }

        [TestMethod]
        public void TestChiTietHDBObj3()
        {
            Assert.AreEqual(ctHDBobj.DonGiaBan, 60000);
        }

        [TestMethod]
        public void TestChiTietHDBObj4()
        {
            Assert.AreEqual(ctHDBobj.SoLuong, 2);
        }


    }
}