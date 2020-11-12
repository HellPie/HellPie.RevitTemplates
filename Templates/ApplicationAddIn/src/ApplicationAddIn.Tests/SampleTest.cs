using System;
using NUnit.Framework;

namespace ApplicationAddIn.Tests {
    public class SampleTest {
        [SetUp]
        public void RunBeforeTest() {
            Console.WriteLine($"Begin testing in {GetType().Name}");
        }

        [TearDown]
        public void RunAfterTest() {
            Console.WriteLine($"Finished testing in {GetType().Name}");
        }

        [Test]
        public void PassTest() {
            Assert.True(true);
        }

        [Test]
        public void FailTest() {
            Assert.True(false, "This test is expected to fail.");
        }
    }
}
