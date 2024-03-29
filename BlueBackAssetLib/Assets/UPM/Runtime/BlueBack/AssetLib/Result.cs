

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief 結果。
*/


/** BlueBack.AssetLib
*/
namespace BlueBack.AssetLib
{
	/** Result
	*/
	public struct Result<VALUE>
	{
		/** success
		*/
		public bool success;

		/** value
		*/
		public VALUE value;

		/** constructor
		*/
		public Result(bool a_success,in VALUE a_value)
		{
			//success
			this.success = a_success;

			//value
			this.value = a_value;
		}
	}
}

