/*
 * Created by SharpDevelop.
 * User: 20-8-15
 * Date: 03/19/2018
 * Time: 12:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace CsvParser
{
	/// <summary>
	/// Read data from csv files
	/// </summary>
	public class Csv
	{
		public static String[][] ReadAllRows(String path){
			String[][] data=ReadAllRows(path,',');
			return data;
		}
		
		
		public static String[][] ReadAllRows(String path,Char delimiter){
			String[] line=File.ReadAllText(path).Split('\n');
			List<String> l=new List<string>();
			for (int i=0;i<line.Length;i++){
				if(line[i].Length>0){
					l.Add(line[i].Remove(line[i].Length-1,1));
				}
			}
			String[][] data=new String[l.ToArray().Length][];
			for (int i=0;i<l.ToArray().Length;i++){
				data[i]=l[i].Split(delimiter);
			}
			return data;
			}
		
		
		public static String[] ReadRow(String path,int index){
			return ReadRow(path,index,',');
		}
		
		
		public static String[] ReadRow(String path,int index,Char delimiter){
			String[] AllLines=File.ReadAllText(path).Split('\n');
			String[] row;
			try{String line=AllLines[index].Remove(AllLines[index].Length-1,1);
				row =line.Split(delimiter);}
			catch(IndexOutOfRangeException e){
				throw( new IndexOutOfRangeException("No such row Exist"));
			}
			return row;
		}
		
		public static void WriteRow(String path,String[] data){
			WriteRow(path,data,',');
			return;
		}
		
		public static void WriteRow(String path,String[] data,Char delimiter){
			String output="";
			for (int i=0;i<data.Length-1;i++){
				output+=data[i];
				output+=delimiter;
			}
			output+=data[data.Length-1];
			output+="\n";
			File.AppendAllText(path,output);
			return;				
		}
	
		public static void WriteRows(String path,String[][] data){
			WriteRows(path,data,',');
			return;
		}
		
		public static void WriteRows(String path,String[][] data,Char delimiter){
			for (int i=0;i<data.Length;i++){
				WriteRow(path,data[i],delimiter);
			}
			return;
		}	
		
	}
}