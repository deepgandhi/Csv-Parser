/*
 * Created by SharpDevelop.
 * User: 20-8-15
 * Date: 03/20/2018
 * Time: 4:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CsvParser
{
	
	public class CsvWriter
	{
		private String p;
		private Char d;
		public CsvWriter(String path,Char Delimiter)
		{
			this.p=path;
			this.d=Delimiter;
		}
		
		public CsvWriter(String path){
			this.p=path;
			this.d=',';
		}
		
		public void WriteRow(String[] row){
			Csv.WriteRow(p,row,d);
		}
		
		public void WriteRows(String[][] rows){
			Csv.WriteRows(p,rows,d);
		}
	}
}
