# Duplicate  Remover
This is a simple script that removes duplicate lines from a text file. It reads the contents of the file, identifies duplicate lines, and writes back only the unique lines to a defined output file.

## How to Use
You need to call it over the command line with (minimum) two arguments: the output file path and the input file path(s).

```
.\duplicate_remover.exe [output_file_path] [input_file_path1] [input_file_path2] ...]
```

There is no limit to the number of input files you can provide (well except any theoretical mathematical limits of computers).
If your given output file doesnt exist, it will be created. If it does exist, it will be overwritten.

## Example
A simple example of how to use the script:
```
.\duplicate_remover.exe "C:\User\You\Desktop\output.txt" "C:\User\You\Desktop\input1.txt" "C:\User\You\Desktop\input2.txt" 
```