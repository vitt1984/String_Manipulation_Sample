/*
 * Created by SharpDevelop.
 * User: Vittorio
 * Date: 20/11/2014
 * Time: 20:15
 * 
 */
using System;

namespace Test1
{ 	
	/// <summary>
	/// StringManipulator: a class with a single static method that reverses an array and sets vowels to upper case
 	/// and consonants to lower case
 	/// 
 	/// Disclaimer: only supports english vowels. Using with words from other languages (german, swedish, french...)
 	/// may result in those some vowels being considered consonants.
 	/// /// TODO find a library that supports different alphabets
	/// </summary>

	static class StringManipulator
	{
		// in order to recognize vowels - all other letters are considered consonants
		private readonly static string _Vowels = "aeiouAEIOU";
		         
		
		public static void Main(string[] args)
        {
			// process args
			foreach (string aString in args)
			{				
				string aNewString = new string(ManipulateCharArray(aString.ToCharArray()));	
                Console.WriteLine(aNewString);
			}
			
			// show a few extra examples
			string[] aSamples = {"Test", "Vittorio", "Sample"};			
			foreach(string aSample in aSamples)
			{
				Console.WriteLine("Original: " + aSample + ", Result: " + String.Concat(StringManipulator.ManipulateCharArray(aSample.ToCharArray())));
			}
				
			Console.ReadKey();
        }
		
		
		/**
		 * ManipulateCharArray:
		 * Paramaters: char[] to be manipulated
		 * Returns: char[] in reversed order with consonant in lower case and vowels in uppercase
		 */
		
		public static char[] ManipulateCharArray(char[] iOriginalArray)
		{
			int aArraySize = iOriginalArray.Length;
			char[] aNewCharArray = new char[aArraySize];

			// reverse the array
			
			for (int aIndex = 0; aIndex<iOriginalArray.Length; aIndex++)
			{
				// we take the last char from the source 
				char aChar = iOriginalArray[aArraySize-aIndex-1];
				
				// only perform to Upper/Lower if it is a Letter
				if (Char.IsLetter(aChar))
				{
					// check to see if this char is a vowel
					if (_Vowels.IndexOf(aChar) >= 0)
					{
						aChar = Char.ToUpper(aChar);
					}
					else
					{
						aChar = Char.ToLower(aChar);					
					}					
				}
				
				aNewCharArray[aIndex]=aChar;
			}
			
			return aNewCharArray;			
		}
	}
}