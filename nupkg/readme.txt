# Csv-Parser
class
 library for working with  Csv files in .Net frameowrk




Static Methods:-

1. 

1. ReadAllRows
  
arguments:- String path,Char delimiter(option)
 
return:- String[][] Rows

read all the rows of the given csv and return jagged string array.



2. ReadRow

arguments:- String path,int index,Char delimiter(option)

return:- String[] Row

read a particular Row of the csv file. Index number starts with 0. and return sting array



3. WriteRow

argument:- String path,String[] Row,Char delimiter(optional)

Write a row to Csv file. data is to be given in String array



4. WriteRows

argument:- String path,String[][] Rows,Char delimiter(optional)

write multiple rows a time to the csv file. Data is to be given in stirng jagged array





CsvReader:-


creates an object of CsvReader. Useful for specifying path and delimiter(optinal) one time and use object fo reading.



1. ReadRow:-

argument:- int index

read the row of particular index.



2. ReadNextRow:-
  
require no arguments
  Start reading row with 0 index and everytime return next row while called.






CsvWriter:-


create object of CsvWriter. Useful for specifyig path and delimiter(optinal) one time and use object for writing



1. WriteRow

argument:- String[] row

write row to the current Csvwriter object.



2. WriteRows

argument:- String[][] rows

write multiple rows to  the current CsvWriter object.
