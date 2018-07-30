using System;
using System.Collections.Generic;
class AnythingYouWant {
  public static void Main (string[] args) {
List<string> mylist = new List<string>(new string[] { "this", "is", "a", "sentence", "that", "Im", "going", "to", "mix"});
  int seconds = 33;
  int theRange = seconds / 5;
  var tempList = mylist.GetRange(0, theRange).ToArray();
    mylist.RemoveRange(0,theRange);
    mylist.AddRange(tempList);
  string joined = String.Join(" ", mylist);

  Console.WriteLine(joined);
  }
// var tempList = mylist.GetRange(0, 1).ToArray();
// mylist.RemoveRange(0,1);
// mylist.AddRange(tempList);
 
  }

  