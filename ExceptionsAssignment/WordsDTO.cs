using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionsAssignment
{
	public class WordsDTO
	{
		public string[]? WordArray {  get; set; }
		public bool IsFileFound { get; set; }
		public string? MyOwnMessage { get; set; }

		string wordsDTOFilePath;

		public WordsDTO(string wordsDTOFilePath)
		{
			this.wordsDTOFilePath = wordsDTOFilePath;		
		}
	}
}
