/*
 * Created by SharpDevelop.
 * User: Vittorio
 * Date: 20/11/2014
 * Time: 20:29
 * 
 * Unit test for the StringManipulator MessUpCharArray static method
 */
using System;
using NUnit.Framework;

namespace Test1
{
	[TestFixture]
	public class UnitTest
	{
		// basic test
		[Test]
		public void TestBasic()
		{
			Assert.AreEqual(StringManipulator.ManipulateCharArray("VittOrio".ToCharArray()), "OIrOttIv".ToCharArray());
		}
		
		// check that it works with non letters as well
		[Test]
		public void TestWithNonLetters()
		{
			Assert.AreEqual(StringManipulator.ManipulateCharArray("Vitt@__\\2 ;orio".ToCharArray()), "OIrO; 2\\__@ttIv".ToCharArray());
		}
		
		// check that it works with empty string
		[Test]
		public void TestWithEmptyString()
		{
			Assert.AreEqual(StringManipulator.ManipulateCharArray("".ToCharArray()), "".ToCharArray());
		}
		
		// Test with all lower case
		[Test]
		public void TestWithAllLowerCase()
		{
			Assert.AreEqual(StringManipulator.ManipulateCharArray("changemetoupper".ToCharArray()), "rEppUOtEmEgnAhc".ToCharArray());
		}
		
		// Test with all upper case
		[Test]
		public void TestWithAllUpperCase()
		{
			Assert.AreEqual(StringManipulator.ManipulateCharArray("CHANGEMETOLOWER".ToCharArray()), "rEwOlOtEmEgnAhc".ToCharArray());
		}
	}
}
