Hey Guys

So this is just a basic Timetable that gets what day of the week it is and then prints the days classes.

I'm making use of text files for educational purposes.

to use it just copy the whole ConsoleApp1 folder somewhere on your PC.

then change this part here
``` language=C-Sharp
System.IO.StreamReader("C:/Users/Keanan/documents/visual studio 2017/Projects/ConsoleApp1/ConsoleApp1/txt/" + dt.ToString("ddd")+".txt");
```

to the full path to your folder

```
"C:/Users/Keanan/documents/visual studio 2017/Projects/ConsoleApp1/ConsoleApp1/txt/"
```
that is the path for my computer, find yours else this wont work.

if you want the .exe file that you can run without opening visual studio it is here:
```
\Timetable\ConsoleApp1\ConsoleApp1\bin\Debug\ConsoleApp1.exe
```

The easiest way to use this would be copy the whole folder to your PC. Change the file Path to your path. Then make a shortcut on your desktop to that .exe

This way whenever you want to check your timetable just click the .exe and it will print your classes for the day.

if you open this on a Saturday or Sunday it will show you Mondays Classes.
