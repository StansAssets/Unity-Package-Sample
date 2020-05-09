// -----------------------------------------------------------------------------
// Editor C# Script Sample
// -----------------------------------------------------------------------------

namespace StansAssets.PackageSample.Editor
{
	/// <summary>
	/// Make sure you have documentation for ALL public Package APIs.
	/// 1 class = 1 file preferable.
	///
	/// You may skip internal classes / methods documentation.
	/// But make sure to document anything that would surprise another engineer (or yourself when you've forgotten it).
	///
	/// You can use normal markdown, such as **bold**, *italics*, and `code` formatting.
	/// Links: [Unity](https://unity.com/)
	/// Refs: <see cref="MyExampleEnum"/>
	/// </summary>
	/// <remarks>
	/// For more information on using the XML Documentation comments and the supported tags,
	/// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments
	///
	/// Code convention:
	/// https://github.com/StansAssets/com.stansassets.foundation/wiki/Code-Convention-Unity-C%23
	/// </remarks>
	public class MyPublicEditorExampleClass
	{
		/// <summary>
		/// If you want to document your public enum, use `summary` tags before each value.
		/// </summary>
		public enum MyExampleEnum
		{
			/// <summary>
			/// Description of value 1
			/// </summary>
			First = 0,
			/// <summary>
			/// Description of value 2
			/// </summary>
			Second = 1,
		}

		/// <summary>
		/// For properties, you can add a description of the property to get/set with the `value` tag.
		/// </summary>
		/// <value> Description of the property </value>
		public MyExampleEnum PropertyExample => MyExampleEnum.First;

		/// <summary>
		/// Besides providing a summary you should also describe each parameter
		/// using the `param` tag and document return values with the `return` tag.
		/// </summary>
		/// <param name="parameter1"> Description of parameter 1. </param>
		/// <param name="parameter2"> Description of parameter 2. </param>
		/// <returns> Description of what the function returns. </returns>
		public int DoSomething(int parameter1, int parameter2)
		{
			return parameter1 + parameter2;
		}
	}
}

