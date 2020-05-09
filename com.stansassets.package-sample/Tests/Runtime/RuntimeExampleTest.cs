// -----------------------------------------------------------------------------
// Package Runtime Tests.
// Test Framework
// https://docs.unity3d.com/Manual/com.unity.test-framework.html
//
// For embedded packages you don’t need to explicitly enable tests because embedded packages are in development.
// However, for other types of dependencies, you need to add the `testables` attribute to the Project `manifest.json`
// "testables" : ["com.stansassets.package-sample"]
// -----------------------------------------------------------------------------

using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine;

namespace StansAssets.PackageSample.Tests
{
    class RuntimeExampleTest
    {
        [SetUp]
        public void Setup()
        {
            // Called before each test method is called.
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Called once prior to executing any of the tests in a fixture
        }

        [UnitySetUp]
        public IEnumerator UnitySetUp()
        {
            // Identical to the standard SetUp.
            yield return null;
        }

        [TearDown]
        public void TearDown()
        {
            // Called after each test method.
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Called once after executing any of the tests in a fixture.
        }

        [UnityTearDown]
        public IEnumerator UnityTearDown()
        {
            // Identical to the standard TearDown.
            yield return null;
        }

        [Test]
        public void SimpleTest()
        {
            // Simple Test
            Assert.That(1, Is.EqualTo(1));
        }

        [Test]
        [UnityPlatform(RuntimePlatform.WindowsPlayer, RuntimePlatform.Android)]
        public void TestMethod()
        {
            // Run test only for defined platforms
            Assert.AreEqual(Application.platform, RuntimePlatform.WindowsPlayer);
        }

        [Test]
        [TestCase("Alex", 101)]
        [TestCase("Pavel", 777)]
        [TestCase("Stan", 707)]
        public void TestMethod(string name, int id)
        {
            // TestCase sample.
        }

        [Test, Ignore("Described the reason why ignored")]
        public void IgnoredTest()
        {
            // Ignore test example.
        }

        [UnityTest]
        public IEnumerator EditorSampleTestWithEnumeratorPasses()
        {
            // A UnityTest behaves like a coroutine in PlayMode
            // and allows you to yield null to skip a frame in EditMode
            yield return null;
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
