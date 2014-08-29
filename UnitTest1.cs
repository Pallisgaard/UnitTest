using System;
using UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestName()
        {
            Student student = new Student("Lasse", 3000);
            Assert.AreEqual("Lasse", student.Name);
        }

        [TestMethod]
        public void TestSu()
        {
            Student student = new Student("Lasse", 3000);
            Assert.AreEqual(3000, student.Su);
        }

        [TestMethod]
        public void TestToString()
        {
            Student student = new Student("Lasse", 3000);
            Assert.AreEqual("Student: Lasse, 3000", student.ToString());
        }

        [TestMethod]
        public void TestConstructor()
        {

            try
            {
                new Student(null, 3000);
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Name is null or Empty", ex.Message);

            }
            try
            {
                new Student("", 3000);
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Name is null or Empty", ex.Message);

            }


        }

        [TestMethod]
        public void TestConstructor2()
        {
            try
            {
                new Student("Lasse", -5);
                Assert.Fail();
            }
            catch (SuException ex)
            {
                Assert.AreEqual("The amount of Su is not valid", ex.Message);
            }
            //catch (ArgumentException ex)
            //{
            //    Assert.AreEqual("The amount of Su is not valid", ex.Message);
            //}
        }

    }
}
