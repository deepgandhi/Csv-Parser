/*
 * Created by SharpDevelop.
 * User: 20-8-15
 * Date: 03/21/2018
 * Time: 2:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CsvParser
{
	/// <summary>
	/// Description of CsvReader.
	/// </summary>
	public class CsvReader
	{private String p;
		private Char d;
		private int i=0;
		public CsvReader(String path)
		{
			this.p=path;
			this.d=',';
		}
		public CsvReader(String path,Char delimiter){
			this.p=path;
			this.d=delimiter;
		}
		
		public String[] ReadRow(int index){
			return Csv.ReadRow(p,index,d);
		}
		
		public String[] ReadNextRow(){
			String[] row=Csv.ReadRow(p,i,d);
			i++;
			return row;
		}
	}
}
